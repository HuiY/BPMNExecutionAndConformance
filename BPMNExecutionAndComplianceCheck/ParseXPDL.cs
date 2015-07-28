using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace BPMNExecutionAndComplianceCheck
{
    class ParseXPDL
    {
            //解析出的文件必须和用java解析出的一模一样，因为engine依赖于其元模型进行的执行。例如我多解析了gateway中的一个attribute，就不能用当前的代码进行执行了。
            static public String TAG_PROCESS = "xpdl2:WorkflowProcess";
	        static public String TAG_ASSOCIATION = "Association";
	
	        static public String ATTRIBUTE_ID = "Id";	
	        static public String ATTRIBUTE_NAME = "Name";	
	        /* The structure of the XML document is mainly determined in: PROCESS ELEMENTS ARE DETERMINED HERE */

            private bool flagSucceed=true;
            public static string parseXPDL(String filename,out bool flag) 
                //throws ParserConfigurationException, SAXException, IOException
            {
                //DocumentBuilderFactory docBuilderFactory = DocumentBuilderFactory.newInstance();
                //docBuilderFactory.setNamespaceAware(true);
                //DocumentBuilder docBuilder = docBuilderFactory.newDocumentBuilder();
                //Document doc = docBuilder.parse(new File(filename));
                flag = true;
                XmlDocument  doc = new XmlDocument();
                doc.Load(filename);

		        XmlNodeList processes = doc.GetElementsByTagName(TAG_PROCESS);
                string fileDirectory = ""; ;

		        for (int i = 0; i < processes.Count; i++)
                {
			        XmlNode process = processes[i];

			        //PrintStream out = new PrintStream(new FileOutputStream(process.getAttributes().getNamedItem(ATTRIBUTE_NAME).getNodeValue() + ".grbpmn"), true);		        	
                    //out.println("new graph BPMN \"BPMN test\"");
                    //out.println("include BPMN.layout");

                    fileDirectory = System.Environment.CurrentDirectory+"\\"+((XmlElement)process).GetAttribute(ATTRIBUTE_NAME) + ".grs";
                    //fileDirectory = "C:\\GrGenNET\\HuiTestBPMN\\TestConformanceCheckRuleStep\\grbpmnfiles\\" + ((XmlElement)process).GetAttribute(ATTRIBUTE_NAME) + ".grbpmn";
                    System.IO.StreamWriter file = new System.IO.StreamWriter(fileDirectory);
                    file.WriteLine("new graph BPMNV7 \"BPMN test\"");
                    //file.WriteLine("include BPMN.layout");                

			        parseProcess((XmlElement) process,file,out flag);			        
                    file.Close();
                    
                    //fileDirectory = "C:\\GrGenNET\\HuiTestBPMN\\TestConformanceCheckRuleStep\\grbpmnfiles\\"+((XmlElement)process).GetAttribute(ATTRIBUTE_NAME)+".grbpmn";
		        }                
                    
                return fileDirectory;
	        }

            public static List<String> parseProcess(XmlElement process,System.IO.StreamWriter file,out bool flagOfS)
            {
                flagOfS = true;
		        /* PROCESS ELEMENTS ARE DETERMINED HERE */
		        List<String> containedElements = new List<string>();

		        // Parse activities except events
		        XmlNodeList processChildren = process.ChildNodes;
		        for (int i = 0; i < processChildren.Count; i++)
                {
			       if ((processChildren[i].Name != null) && processChildren[i].Name==("xpdl2:Activities"))
                   {
				        //XmlNodeList activities = processChildren[i].get("Activity");
                        XmlNodeList activities=processChildren[i].ChildNodes;
				        for (int j = 0; j < activities.Count; j++)
                        {
                            if(activities[j].Name=="xpdl2:Activity"&&activities[j].NodeType==XmlNodeType.Element)
                            {
					            XmlNode node = activities[j];        	
					            //Parse tasks
					            if (((XmlElement)node).GetElementsByTagName("Task","*").Count == 1){
						            String id = parseTask(node, file);
						            containedElements.Add(id);
					            }
                                if (((XmlElement)node).GetElementsByTagName("No", "*").Count == 1)
                                {
						            String id = parseTask(node, file);
						            containedElements.Add(id);
					            }
					            //Parse gateways
                                if (((XmlElement)node).GetElementsByTagName("Route", "*").Count == 1)
                                {
						            String id = parseGateway(node, file);
						            containedElements.Add(id);
					            }
					            //Parse embedded subprocesses
                                if (((XmlElement)node).GetElementsByTagName("BlockActivity", "*").Count == 1)
                                {
						            String id = parseEmbeddedSub(node, file);
						            containedElements.Add(id);
					            }
					            //Parse referenced subprocesses
                                if (((XmlElement)node).GetElementsByTagName("SubFlow", "*").Count == 1)
                                {
						            String id = parseReferencedSub(node, file,out flagOfS);
                                    if (!flagOfS)
                                    {
                                        break;
                                    }
						            containedElements.Add(id);
					            }
                            }
				    }
			    }
		    }
		
		    //Parse events only now, to prevent boundary events from being parsed before the activity on which' boundary they are is defined
		    for (int i = 0; i < processChildren.Count; i++){
			    if ((processChildren[i].Name != null) && processChildren[i].Name.Equals("xpdl2:Activities")){
                    XmlNodeList activities = ((XmlElement)processChildren[i]).GetElementsByTagName("xpdl2:Activity");
				    for (int j = 0; j < activities.Count; j++)
                    {
					    XmlNode node = activities[j];        	
					    //Parse events
                        if (((XmlElement)node).GetElementsByTagName("xpdl2:Event").Count == 1)
                        {
						    String id = parseEvent(node, file);
						    containedElements.Add(id);
					    }
				    }
			    }
		    }
		
		    //Parse transitions 
            processChildren = process.ChildNodes;
		    for (int i = 0; i < processChildren.Count; i++){
			    if ((processChildren[i].Name != null) && processChildren[i].Name.Equals("xpdl2:Transitions")){
                    XmlNodeList transitions = ((XmlElement)processChildren[i]).GetElementsByTagName("xpdl2:Transition");
				    for (int j = 0; j < transitions.Count; j++){
					    XmlNode node = transitions[j];        	
					    parseTransition(node, file);
				    }
			    }
		    }
		
		    //Parse Associations, Hui did not test it yet.
		    XmlNodeList associations = process.OwnerDocument.GetElementsByTagName(TAG_ASSOCIATION,"*");
		    for (int i = 0; i < associations.Count; i++){
                String asssource = normalizeId(((XmlElement)associations[i]).GetAttribute("Source"));
			    String asstarget = normalizeId(((XmlElement)associations[i]).GetAttribute("Target"));
			    if (containedElements.Contains(asssource) && containedElements.Contains(asstarget)){
                    file.WriteLine("new @(\"" + asssource + "\") -:Association()-> @(\"" + asstarget + "\")");
			    }
		    }		

		    return containedElements;
	        }
            public static String parseTask(XmlNode node,System.IO.StreamWriter file)
            {
		        String id = getId(node);
		        String[] atts = {"Name"};
		        file.Write("new :Task($=\"" + id + "\"");
                //List<String> attributes = parseAttributes(node, atts);
                //if (attributes.Count !=0 ){file.Write(",");}
                //printAttributes(attributes,file);
                //file.WriteLine(")");
                List<String> attributes = parseAttributes(node, atts);
                if (attributes.Count != 0) { file.Write(","); }
                printAttributes(attributes, file);
                file.WriteLine(")");	
		        parseActivityLoop(node,file);
		        return id;

                
	        }

            public static String getId(XmlNode node)
            {
		        //return normalizeId(node.getAttributes().getNamedItem(ATTRIBUTE_ID).getNodeValue());
                return normalizeId(((XmlElement)node).GetAttribute(ATTRIBUTE_ID));
	        }
	
	        public static String normalizeId(String id){
		        return id.Replace("-", "__").Replace("$", "_");
	        }

	        public static String parseSubprocess(XmlNode node, System.IO.StreamWriter file){
                bool flag;
		        String id = getId(node);
		        file.Write("new :ActivitySet($=\"" + id + "\")");
		        List<String> containedElements = parseProcess((XmlElement) node,file,out flag);		
		        foreach (String contained in containedElements){
			        file.WriteLine("new @(\"" + id + "\") -:Contains()-> @(\"" + contained + "\")");
		        }

		        return id;
	        }
            public static String parseEvent(XmlNode node, System.IO.StreamWriter file){
		    String id = getId(node);
		    //Parse start event
            if (((XmlElement)node).GetElementsByTagName("xpdl2:StartEvent").Count == 1)
            {
			    String[] attnames = {"Name"};
			    file.Write("new :StartEvent($=\"" + id + "\"");
			    XmlNode starteventnode = ((XmlElement)node).GetElementsByTagName("xpdl2:StartEvent")[0];
			    String[] starteventattnames = {"Trigger"};
			    List<String> atts = parseAttributes(node, attnames);
			    atts.AddRange(parseAttributes(starteventnode, starteventattnames));
                if (atts.Count != 0) { file.Write(","); }
			    printAttributes(atts,file);
			    file.WriteLine(")");
            }
            else if (((XmlElement)node).GetElementsByTagName("xpdl2:IntermediateEvent").Count == 1)
            {
			    String[] attnames = {"Name"};
                XmlNode intermediateeventnode = ((XmlElement)node).GetElementsByTagName("IntermediateEvent","*")[0];
			    String[] starteventattnames = {"Trigger"};
			    List<String> atts = parseAttributes(node, attnames);
			    atts.AddRange(parseAttributes(intermediateeventnode, starteventattnames));
			    XmlNode resultnode = ((XmlElement)intermediateeventnode).GetElementsByTagName("ResultError")[0];
			    if (resultnode != null){
				    String[] resultnodeattnames = {"ErrorCode"};
				    atts.AddRange(parseAttributes(resultnode, resultnodeattnames));
			    }
			    bool isThrowEvent = false;
                XmlNode triggerresultnode = ((XmlElement)intermediateeventnode).GetElementsByTagName("TriggerResult" + ((XmlElement)intermediateeventnode).GetAttribute("Trigger"), "*")[0];
			    if (triggerresultnode != null){
				    if (((XmlElement)triggerresultnode).GetAttribute("xpdExt:CatchThrow") != null){
					    isThrowEvent = ((XmlElement)triggerresultnode).GetAttribute("xpdExt:CatchThrow").Equals("THROW");
				    }
			    }
			    if (isThrowEvent){
				    file.Write("new :IntermediateThrowEvent($=\"" + id + "\"");
			    }else{
				    file.Write("new :IntermediateCatchEvent($=\"" + id + "\"");				
			    }
			    atts.AddRange(parseTriggerResultNameAttribute(intermediateeventnode));
			    if (atts.Count!=0){file.Write(",");}
			    printAttributes(atts,file);			
			    file.WriteLine(")");
			
			    //If the intermediate event is a boundary event on an activity, store the ID of that activity
                if (((XmlElement)intermediateeventnode).GetAttribute("Target") != null && ((XmlElement)intermediateeventnode).GetAttribute("Target") != "")
			    //if (((XmlElement)intermediateeventnode).GetAttribute("Target") != "")
                {
				    file.Write("new @(\"" + id + "\") -:Target()-> @(\"");
				    file.WriteLine(normalizeId(((XmlElement)intermediateeventnode).GetAttribute("Target")) + "\")");
			    }

			    //If the intermediate event is a compensation event for an activity, store the ID of that activity
                XmlNode compensationnode = ((XmlElement)intermediateeventnode).GetElementsByTagName("TriggerResultCompensation")[0];
			    if ((compensationnode != null) && (((XmlElement)compensationnode).GetAttribute("ActivityId") != null)){
				    file.Write("new @(\"" + id + "\") -:activityRef()-> @(\"");
				    file.WriteLine(normalizeId(((XmlElement)compensationnode).GetAttribute("ActivityId")) + "\")");
			    }
            }
            else if (((XmlElement)node).GetElementsByTagName("xpdl2:EndEvent").Count == 1)
            {
			    String[] attnames = {"Name"};
			    file.Write("new :EndEvent($=\"" + id + "\"");
                XmlNode endeventnode = ((XmlElement)node).GetElementsByTagName("xpdl2:EndEvent")[0];
			    String[] starteventattnames = {"Result"};
			    List<String> atts = parseAttributes(node, attnames);
			    atts.AddRange(parseAttributes(endeventnode, starteventattnames));
                XmlNode resultnode = ((XmlElement)endeventnode).GetElementsByTagName("ResultError")[0];
			    if (resultnode != null){
				    String[] resultnodeattnames = {"ErrorCode"};
				    atts.AddRange(parseAttributes(resultnode, resultnodeattnames));
			    }
			    atts.AddRange(parseTriggerResultNameAttribute(endeventnode));
                if (atts.Count != 0) { file.Write(","); }
			    printAttributes(atts,file);
			    file.WriteLine(")");
		    }
		    return id;
	    }
	    public static String parseGateway(XmlNode node,System.IO.StreamWriter file){
		        String id = getId(node);
		        //String[] attnames = {"GatewayType","ExclusiveType","Instantiate"};
                String[] attnames = { "GatewayType", "ExclusiveType"};
		        file.Write("new :Gateway($=\"" + id + "\"");
                XmlNode eleXmlRout=((XmlElement)node).GetElementsByTagName("Route","*")[0];
                List<String> atts = parseAttributes(eleXmlRout, attnames);
                if (atts.Count != 0) { file.Write(","); }
                if (atts[0] == "GatewayType=\"Parallel\"")
                {
                    file.Write(atts[0]);
                }
                else if (atts[0] == "GatewayType=\"Inclusive\"")
                {
                    file.Write(atts[0]);
                }
                else 
                {
                    printAttributes(atts, file);	
                }
                file.WriteLine(")");			        
		        return id;
	        }
	    public static String parseEmbeddedSub(XmlNode node, System.IO.StreamWriter file){
            bool flag;
		    String id = getId(node);
		
		    //Find and parse the subprocess
            XmlNode blocknode = ((XmlElement)node).GetElementsByTagName("BlockActivity","*")[0];
		    String refprocid = normalizeId(((XmlElement)blocknode).GetAttribute("ActivitySetId"));
		    List<String> containedNodes = new List<string>();
            XmlNodeList processChildren;
            //distinguish between one level subprocess and two level suprocess
            if(node.ParentNode.ParentNode.Name.Equals("xpdl2:ActivitySet"))
            {
                processChildren = node.ParentNode.ParentNode.ParentNode.ParentNode.ChildNodes;
                for (int i = 0; i < processChildren.Count; i++)
                {
                    if ((processChildren[i].Name != null) && processChildren[i].Name.Equals("xpdl2:ActivitySets"))
                    {
                        XmlNodeList subprocesses = processChildren[i].ChildNodes;
                        for (int j = 0; j < subprocesses.Count; j++)
                        {
                            if ((subprocesses[j].Name != null) && subprocesses[j].Name.Equals("xpdl2:ActivitySet"))
                            {
                                XmlNode subprocess = subprocesses[j];
                                if (getId(subprocess).Equals(refprocid))
                                {
                                    containedNodes.AddRange(parseProcess((XmlElement)subprocess, file, out flag));
                                }
                            }
                        }
                    }
                }
            }
            else if (node.ParentNode.ParentNode.Name.Equals("xpdl2:WorkflowProcess"))
            {
                processChildren = node.ParentNode.ParentNode.ChildNodes;
                for (int i = 0; i < processChildren.Count; i++)
                {
                    if ((processChildren[i].Name != null) && processChildren[i].Name.Equals("xpdl2:ActivitySets"))
                    {
                        XmlNodeList subprocesses = processChildren[i].ChildNodes;
                        for (int j = 0; j < subprocesses.Count; j++)
                        {
                            if ((subprocesses[j].Name != null) && subprocesses[j].Name.Equals("xpdl2:ActivitySet"))
                            {
                                XmlNode subprocess = subprocesses[j];
                                if (getId(subprocess).Equals(refprocid))
                                {
                                    containedNodes.AddRange(parseProcess((XmlElement)subprocess, file, out flag));
                                }
                            }
                        }
                    }
                }
            } 
		
		    //Parse the referencing activity
		    String[] attnames = {"Name"};
		    file.Write("new :BlockActivity($=\"" + id + "\"");
		    List<String> atts = parseAttributes(node, attnames);
            if (atts.Count != 0) { file.Write(","); }
		    printAttributes(atts, file);		
		    file.WriteLine(")");		
		    foreach (String contained in containedNodes){
			    file.WriteLine("new @(\"" + id + "\") -:Contains()-> @(\"" + contained + "\")");
		    }
		    parseActivityLoop(node,file);
		
		    return id;
	    }
        public static String parseReferencedSub(XmlNode node, System.IO.StreamWriter file,out bool flagofSucceed)
        {
            flagofSucceed = true;
            String id = getId(node);

            //Load and parse the subprocess
            XmlNode blocknode = ((XmlElement)node).GetElementsByTagName("SubFlow","*")[0];
            String reffile = ((XmlElement)blocknode).GetAttribute("PackageRef");
            String refprocid = normalizeId(((XmlElement)blocknode).GetAttribute("Id"));
            List<String> containedNodes = new List<string>();
            XmlDocument d = node.OwnerDocument;
            string[] origiFileAddress = d.BaseURI.Split('/');
            int filelength = origiFileAddress[(origiFileAddress.Length - 1)].Length;
            int foreLength=(origiFileAddress[0].Length+origiFileAddress[1].Length+origiFileAddress[2].Length+3);
            string adress = d.BaseURI.Substring(foreLength, d.BaseURI.Length - foreLength-filelength) + reffile + ".xpdl";
            if (System.IO.File.Exists(adress))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(adress);

                XmlNodeList processes = doc.GetElementsByTagName(TAG_PROCESS);

                for (int i = 0; i < processes.Count; i++)
                {
                    XmlNode process = processes[i];
                    if (getId(process).Equals(refprocid))
                    {
                        containedNodes.AddRange(parseProcess((XmlElement)process, file,out flagofSucceed));
                    }
                }

            }
            else
            {
                MessageBox.Show("Subprocess "+reffile+".xpdl does not exist !");
                flagofSucceed = false;
                return "";
            }
            
            //Parse the referencing activity
            String[] attnames = { "Name" };
            file.Write("new :BlockActivity($=\"" + id + "\"");
            List<String> atts = parseAttributes(node, attnames);
            if (atts.Count != 0) { file.Write(","); }
            printAttributes(atts, file);
            file.WriteLine(")");
            foreach (String contained in containedNodes)
            {
                file.WriteLine("new @(\"" + id + "\") -:Contains()-> @(\"" + contained + "\")");
            }
            parseActivityLoop(node, file);

            return id;
        }
	    public static void parseTransition(XmlNode node, System.IO.StreamWriter file){
		    String id = getId(node);
		    file.Write("new :_SequenceFlow($=\"" + id + "\"");
		    XmlNodeList conditionnodes = ((XmlElement)node).GetElementsByTagName("Condition");
		    if (conditionnodes.Count == 1){
			    String[] attnames = {"Type"};
			    List<String> atts = parseAttributes(conditionnodes[0], attnames);
			    if (atts.Count!=0){file.Write(",");}			
			    printAttributes(atts, file);
		    }
		    file.WriteLine(")");
		    file.WriteLine("new @(\"" + normalizeId(((XmlElement)(node)).GetAttribute("From")) + "\") -:_From-> @(\"" + id + "\")");
		    file.WriteLine("new @(\"" + id + "\") -:_To-> @(\"" + normalizeId(((XmlElement)(node)).GetAttribute("To") + "\")"));
	    }
	    public static void parseActivityLoop(XmlNode node, System.IO.StreamWriter file) {
		    XmlNode loopnode = ((XmlElement)node).GetElementsByTagName("Loop")[0];
		    if (loopnode != null){
			    if (((XmlElement)loopnode).GetAttribute("LoopType").Equals("Standard")){
                    XmlNode standardloopnode = ((XmlElement)loopnode).GetElementsByTagName("LoopStandard")[0];
				    bool testBefore = ((XmlElement)standardloopnode).GetAttribute("TestTime").Equals("Before");
				
				    String loopOfId = getId(node);
				    String loopId = loopOfId + "LOOP";
				
				    file.WriteLine("new :StandardLoopCharacteristics($=\""+ loopId + "\",TestBefore=\"" + (testBefore?"true":"false") + "\")");
				    file.WriteLine("new @(\"" + loopOfId + "\") -:loopCharacteristics()-> @(\"" + loopId + "\")");
			    }
		    }
	    }
        public static List<String> parseAttributes(XmlNode ofNode, String[] attNames)
        {
		    return parseAttributes(ofNode,attNames,attNames);
	    }
        public static List<String> parseAttributes(XmlNode ofNode, String[] attNames, String[] attNamesInString)
        {
            List<String> result = new List<String>();
		    for (int j = 0; j < attNames.Length; j++){
			    if (((XmlElement)ofNode).GetAttribute(attNames[j]) != null){
				    String exclusiveType = "";
				    if (attNames[j].Equals("ExclusiveType")){
					    exclusiveType = "ExclusiveType::";
				    }
				    result.Add(attNamesInString[j] + "=\"" + exclusiveType + ((XmlElement)ofNode).GetAttribute(attNames[j]) + "\"");
			    }
		    }
		    return result;
	    }
	    public void parseAttributesAsReferences(XmlNode ofNode, String[] attNames, System.IO.StreamWriter file){
		    for (int j = 0; j < attNames.Length; j++){
			    if (((XmlElement)ofNode).GetAttribute(attNames[j]) != null){
				    file.Write("new @(\"" + getId(ofNode) + "\")-:" + attNames[j] + "->@(\"");
				    file.WriteLine(normalizeId(((XmlElement)ofNode).GetAttribute(attNames[j])) + "\")");
			    }
		    }		
	    }
	    public static List<String> parseTriggerResultNameAttribute(XmlNode ofNode){
            List<String> result = new List<String>();
		    XmlNode triggerresultnode = null;
		    if (((XmlElement)ofNode).GetAttribute("Trigger") != null){
                triggerresultnode = ((XmlElement)ofNode).GetElementsByTagName("TriggerResult" + ((XmlElement)ofNode).GetAttribute("Trigger"))[0];
		    }
		    if (triggerresultnode == null){
			    if (((XmlElement)ofNode).GetAttribute("Result") != null){
                    triggerresultnode = ((XmlElement)ofNode).GetElementsByTagName("TriggerResult" + ((XmlElement)ofNode).GetAttribute("Result"))[0];
			    }
		    }
		    if (triggerresultnode != null){
			    if (((XmlElement)triggerresultnode).GetAttribute("Name") != null){
				    result.Add("EventDefinitionName=\""+((XmlElement)triggerresultnode).GetAttribute("Name")+"\"");
			    }
		    }		
		    return result;
	    }
	    public static void printAttributes(List<String> attributes,System.IO.StreamWriter file){
            for (int i = 0; i < attributes.Count;i++ )
            {
                file.Write(attributes[i]);
                if (i!=(attributes.Count-1))
                {
                    file.Write(",");
                }
            }
	    }


    }
}
