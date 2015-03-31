// This file has been generated automatically by GrGen (www.grgen.net)
// Do not modify this file! Any changes will be lost!
// Generated from "BPMNV3.grg" on Fri Oct 10 11:41:23 CEST 2014

using System;
using System.Collections.Generic;
using GRGEN_LIBGR = de.unika.ipd.grGen.libGr;
using GRGEN_LGSP = de.unika.ipd.grGen.lgsp;

namespace de.unika.ipd.grGen.Model_BPMN
{
	using GRGEN_MODEL = de.unika.ipd.grGen.Model_BPMN;
	//
	// Enums
	//

	public enum ENUM_PIstate { @active = 0, @incancellation = 1, @cancelled = 2, @terminated = 3, @failed = 4, @completing = 5, @completed = 6, @compensating = 7, @compensated = 8, };

	public enum ENUM_TriggerType { @None = 0, @Message = 1, @Timer = 2, @Error = 3, @Cancel = 4, @Conditional = 5, @Link = 6, @Signal = 7, @Compensation = 8, @Multiple = 9, @Terminate = 10, };

	public enum ENUM_GatewayType { @Exclusive = 0, @Inclusive = 1, @Complex = 2, @Parallel = 3, @Event = 4, };

	public enum ENUM_ExclusiveType { @Data = 0, @Event = 1, };

	public enum ENUM_ConditionType { @NULL = 0, @CONDITION = 1, @OTHERWISE = 2, };

	public enum ENUM_SimulatorState { @execute = 0, @statespacegen = 1, };

	public class Enums
	{
		public static GRGEN_LIBGR.EnumAttributeType @PIstate = new GRGEN_LIBGR.EnumAttributeType("PIstate", typeof(GRGEN_MODEL.ENUM_PIstate), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "active"),
			new GRGEN_LIBGR.EnumMember(1, "incancellation"),
			new GRGEN_LIBGR.EnumMember(2, "cancelled"),
			new GRGEN_LIBGR.EnumMember(3, "terminated"),
			new GRGEN_LIBGR.EnumMember(4, "failed"),
			new GRGEN_LIBGR.EnumMember(5, "completing"),
			new GRGEN_LIBGR.EnumMember(6, "completed"),
			new GRGEN_LIBGR.EnumMember(7, "compensating"),
			new GRGEN_LIBGR.EnumMember(8, "compensated"),
		});
		public static GRGEN_LIBGR.EnumAttributeType @TriggerType = new GRGEN_LIBGR.EnumAttributeType("TriggerType", typeof(GRGEN_MODEL.ENUM_TriggerType), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "None"),
			new GRGEN_LIBGR.EnumMember(1, "Message"),
			new GRGEN_LIBGR.EnumMember(2, "Timer"),
			new GRGEN_LIBGR.EnumMember(3, "Error"),
			new GRGEN_LIBGR.EnumMember(4, "Cancel"),
			new GRGEN_LIBGR.EnumMember(5, "Conditional"),
			new GRGEN_LIBGR.EnumMember(6, "Link"),
			new GRGEN_LIBGR.EnumMember(7, "Signal"),
			new GRGEN_LIBGR.EnumMember(8, "Compensation"),
			new GRGEN_LIBGR.EnumMember(9, "Multiple"),
			new GRGEN_LIBGR.EnumMember(10, "Terminate"),
		});
		public static GRGEN_LIBGR.EnumAttributeType @GatewayType = new GRGEN_LIBGR.EnumAttributeType("GatewayType", typeof(GRGEN_MODEL.ENUM_GatewayType), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "Exclusive"),
			new GRGEN_LIBGR.EnumMember(1, "Inclusive"),
			new GRGEN_LIBGR.EnumMember(2, "Complex"),
			new GRGEN_LIBGR.EnumMember(3, "Parallel"),
			new GRGEN_LIBGR.EnumMember(4, "Event"),
		});
		public static GRGEN_LIBGR.EnumAttributeType @ExclusiveType = new GRGEN_LIBGR.EnumAttributeType("ExclusiveType", typeof(GRGEN_MODEL.ENUM_ExclusiveType), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "Data"),
			new GRGEN_LIBGR.EnumMember(1, "Event"),
		});
		public static GRGEN_LIBGR.EnumAttributeType @ConditionType = new GRGEN_LIBGR.EnumAttributeType("ConditionType", typeof(GRGEN_MODEL.ENUM_ConditionType), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "NULL"),
			new GRGEN_LIBGR.EnumMember(1, "CONDITION"),
			new GRGEN_LIBGR.EnumMember(2, "OTHERWISE"),
		});
		public static GRGEN_LIBGR.EnumAttributeType @SimulatorState = new GRGEN_LIBGR.EnumAttributeType("SimulatorState", typeof(GRGEN_MODEL.ENUM_SimulatorState), new GRGEN_LIBGR.EnumMember[] {
			new GRGEN_LIBGR.EnumMember(0, "execute"),
			new GRGEN_LIBGR.EnumMember(1, "statespacegen"),
		});
	}

	//
	// Node types
	//

	public enum NodeTypes { @Node, @WorkflowProcess, @AbstrProcessInstance, @ProcessInstance, @VisibleProcessInstance, @BaseElement, @FlowElement, @FlowElementsContainer, @Activity, @LoopCharacteristics, @StandardLoopCharacteristics, @MultipleInstanceLoopCharacteristics, @AbstrToken, @Token, @HiddenElement, @HiddenToken, @HiddenHistoryToken, @HiddenUndoToken, @HiddenUndoneToken, @HistoryToken, @UndoToken, @UndoneToken, @PException, @Task, @Event, @BlockActivity, @ActivitySet, @StartEvent, @EndEvent, @IntermediateEvent, @IntermediateCatchEvent, @IntermediateThrowEvent, @Gateway, @_Flow, @_SequenceFlow, @_MessageFlow, @dMarker, @_Association, @Marking, @HighlightMarking, @MarkingFromLog, @MnextWithCause, @DummyInt, @SimulatorSettings };

	// *** Node Node ***


	public sealed class @Node : GRGEN_LGSP.LGSPNode, GRGEN_LIBGR.INode
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Node[] pool = new GRGEN_MODEL.@Node[10];
		
		static @Node() {
		}
		
		public @Node() : base(GRGEN_MODEL.NodeType_Node.typeVar)
		{
			// implicit initialization, map/set creation of Node
		}

		public static GRGEN_MODEL.NodeType_Node TypeInstance { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Node(this); }

		private @Node(GRGEN_MODEL.@Node oldElem) : base(GRGEN_MODEL.NodeType_Node.typeVar)
		{
		}
		public static GRGEN_MODEL.@Node CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Node node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Node();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Node
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Node CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@Node node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Node();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Node
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"Node\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"Node\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Node
		}
	}

	public sealed class NodeType_Node : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Node typeVar = new GRGEN_MODEL.NodeType_Node();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
		public NodeType_Node() : base((int) NodeTypes.@Node)
		{
		}
		public override string Name { get { return "Node"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.libGr.INode"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Node"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Node();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@Node();
		}

	}

	// *** Node WorkflowProcess ***

	public interface IWorkflowProcess : IFlowElementsContainer
	{
	}

	public sealed class @WorkflowProcess : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IWorkflowProcess
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@WorkflowProcess[] pool = new GRGEN_MODEL.@WorkflowProcess[10];
		
		// explicit initializations of BaseElement for target WorkflowProcess
		// implicit initializations of BaseElement for target WorkflowProcess
		// explicit initializations of FlowElementsContainer for target WorkflowProcess
		// implicit initializations of FlowElementsContainer for target WorkflowProcess
		// explicit initializations of WorkflowProcess for target WorkflowProcess
		// implicit initializations of WorkflowProcess for target WorkflowProcess
		static @WorkflowProcess() {
		}
		
		public @WorkflowProcess() : base(GRGEN_MODEL.NodeType_WorkflowProcess.typeVar)
		{
			// implicit initialization, map/set creation of WorkflowProcess
			// explicit initializations of BaseElement for target WorkflowProcess
			// explicit initializations of FlowElementsContainer for target WorkflowProcess
			// explicit initializations of WorkflowProcess for target WorkflowProcess
		}

		public static GRGEN_MODEL.NodeType_WorkflowProcess TypeInstance { get { return GRGEN_MODEL.NodeType_WorkflowProcess.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@WorkflowProcess(this); }

		private @WorkflowProcess(GRGEN_MODEL.@WorkflowProcess oldElem) : base(GRGEN_MODEL.NodeType_WorkflowProcess.typeVar)
		{
		}
		public static GRGEN_MODEL.@WorkflowProcess CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@WorkflowProcess node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@WorkflowProcess();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of WorkflowProcess
				// explicit initializations of BaseElement for target WorkflowProcess
				// explicit initializations of FlowElementsContainer for target WorkflowProcess
				// explicit initializations of WorkflowProcess for target WorkflowProcess
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@WorkflowProcess CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@WorkflowProcess node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@WorkflowProcess();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of WorkflowProcess
				// explicit initializations of BaseElement for target WorkflowProcess
				// explicit initializations of FlowElementsContainer for target WorkflowProcess
				// explicit initializations of WorkflowProcess for target WorkflowProcess
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"WorkflowProcess\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"WorkflowProcess\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of WorkflowProcess
			// explicit initializations of BaseElement for target WorkflowProcess
			// explicit initializations of FlowElementsContainer for target WorkflowProcess
			// explicit initializations of WorkflowProcess for target WorkflowProcess
		}
	}

	public sealed class NodeType_WorkflowProcess : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_WorkflowProcess typeVar = new GRGEN_MODEL.NodeType_WorkflowProcess();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_WorkflowProcess() : base((int) NodeTypes.@WorkflowProcess)
		{
		}
		public override string Name { get { return "WorkflowProcess"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IWorkflowProcess"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@WorkflowProcess"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@WorkflowProcess();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@WorkflowProcess();
		}

	}

	// *** Node AbstrProcessInstance ***

	public interface IAbstrProcessInstance : GRGEN_LIBGR.INode
	{
		GRGEN_MODEL.ENUM_PIstate @state { get; set; }
	}

	public sealed class @AbstrProcessInstance : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IAbstrProcessInstance
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@AbstrProcessInstance[] pool = new GRGEN_MODEL.@AbstrProcessInstance[10];
		
		// explicit initializations of AbstrProcessInstance for target AbstrProcessInstance
		// implicit initializations of AbstrProcessInstance for target AbstrProcessInstance
		static @AbstrProcessInstance() {
		}
		
		public @AbstrProcessInstance() : base(GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar)
		{
			// implicit initialization, map/set creation of AbstrProcessInstance
			// explicit initializations of AbstrProcessInstance for target AbstrProcessInstance
		}

		public static GRGEN_MODEL.NodeType_AbstrProcessInstance TypeInstance { get { return GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@AbstrProcessInstance(this); }

		private @AbstrProcessInstance(GRGEN_MODEL.@AbstrProcessInstance oldElem) : base(GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar)
		{
			state\u0303 = oldElem.state\u0303;
		}
		public static GRGEN_MODEL.@AbstrProcessInstance CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@AbstrProcessInstance node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@AbstrProcessInstance();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of AbstrProcessInstance
				node.@state = 0;
				// explicit initializations of AbstrProcessInstance for target AbstrProcessInstance
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@AbstrProcessInstance CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@AbstrProcessInstance node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@AbstrProcessInstance();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of AbstrProcessInstance
				node.@state = 0;
				// explicit initializations of AbstrProcessInstance for target AbstrProcessInstance
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private GRGEN_MODEL.ENUM_PIstate state\u0303;
		public GRGEN_MODEL.ENUM_PIstate @state
		{
			get { return state\u0303; }
			set { state\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "state": return this.@state;
			}
			throw new NullReferenceException(
				"The node type \"AbstrProcessInstance\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "state": this.@state = (GRGEN_MODEL.ENUM_PIstate) value; return;
			}
			throw new NullReferenceException(
				"The node type \"AbstrProcessInstance\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of AbstrProcessInstance
			this.@state = 0;
			// explicit initializations of AbstrProcessInstance for target AbstrProcessInstance
		}
	}

	public sealed class NodeType_AbstrProcessInstance : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_AbstrProcessInstance typeVar = new GRGEN_MODEL.NodeType_AbstrProcessInstance();
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_state;
		public NodeType_AbstrProcessInstance() : base((int) NodeTypes.@AbstrProcessInstance)
		{
			AttributeType_state = new GRGEN_LIBGR.AttributeType("state", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@PIstate, null, null, null);
		}
		public override string Name { get { return "AbstrProcessInstance"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IAbstrProcessInstance"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@AbstrProcessInstance"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@AbstrProcessInstance();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_state;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "state" : return AttributeType_state;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@AbstrProcessInstance newNode = new GRGEN_MODEL.@AbstrProcessInstance();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@AbstrProcessInstance:
				case (int) NodeTypes.@ProcessInstance:
				case (int) NodeTypes.@VisibleProcessInstance:
					// copy attributes for: AbstrProcessInstance
					{
						GRGEN_MODEL.IAbstrProcessInstance old = (GRGEN_MODEL.IAbstrProcessInstance) oldNode;
						newNode.@state = old.@state;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node ProcessInstance ***

	public interface IProcessInstance : IAbstrProcessInstance
	{
	}

	public sealed class @ProcessInstance : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IProcessInstance
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@ProcessInstance[] pool = new GRGEN_MODEL.@ProcessInstance[10];
		
		// explicit initializations of AbstrProcessInstance for target ProcessInstance
		// implicit initializations of AbstrProcessInstance for target ProcessInstance
		// explicit initializations of ProcessInstance for target ProcessInstance
		// implicit initializations of ProcessInstance for target ProcessInstance
		static @ProcessInstance() {
		}
		
		public @ProcessInstance() : base(GRGEN_MODEL.NodeType_ProcessInstance.typeVar)
		{
			// implicit initialization, map/set creation of ProcessInstance
			// explicit initializations of AbstrProcessInstance for target ProcessInstance
			// explicit initializations of ProcessInstance for target ProcessInstance
		}

		public static GRGEN_MODEL.NodeType_ProcessInstance TypeInstance { get { return GRGEN_MODEL.NodeType_ProcessInstance.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@ProcessInstance(this); }

		private @ProcessInstance(GRGEN_MODEL.@ProcessInstance oldElem) : base(GRGEN_MODEL.NodeType_ProcessInstance.typeVar)
		{
			state\u0303 = oldElem.state\u0303;
		}
		public static GRGEN_MODEL.@ProcessInstance CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@ProcessInstance node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@ProcessInstance();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of ProcessInstance
				node.@state = 0;
				// explicit initializations of AbstrProcessInstance for target ProcessInstance
				// explicit initializations of ProcessInstance for target ProcessInstance
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@ProcessInstance CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@ProcessInstance node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@ProcessInstance();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of ProcessInstance
				node.@state = 0;
				// explicit initializations of AbstrProcessInstance for target ProcessInstance
				// explicit initializations of ProcessInstance for target ProcessInstance
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private GRGEN_MODEL.ENUM_PIstate state\u0303;
		public GRGEN_MODEL.ENUM_PIstate @state
		{
			get { return state\u0303; }
			set { state\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "state": return this.@state;
			}
			throw new NullReferenceException(
				"The node type \"ProcessInstance\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "state": this.@state = (GRGEN_MODEL.ENUM_PIstate) value; return;
			}
			throw new NullReferenceException(
				"The node type \"ProcessInstance\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of ProcessInstance
			this.@state = 0;
			// explicit initializations of AbstrProcessInstance for target ProcessInstance
			// explicit initializations of ProcessInstance for target ProcessInstance
		}
	}

	public sealed class NodeType_ProcessInstance : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_ProcessInstance typeVar = new GRGEN_MODEL.NodeType_ProcessInstance();
		public static bool[] isA = new bool[] { true, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_ProcessInstance() : base((int) NodeTypes.@ProcessInstance)
		{
		}
		public override string Name { get { return "ProcessInstance"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IProcessInstance"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@ProcessInstance"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@ProcessInstance();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_AbstrProcessInstance.AttributeType_state;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "state" : return GRGEN_MODEL.NodeType_AbstrProcessInstance.AttributeType_state;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@ProcessInstance newNode = new GRGEN_MODEL.@ProcessInstance();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@AbstrProcessInstance:
				case (int) NodeTypes.@VisibleProcessInstance:
					// copy attributes for: AbstrProcessInstance
					{
						GRGEN_MODEL.IAbstrProcessInstance old = (GRGEN_MODEL.IAbstrProcessInstance) oldNode;
						newNode.@state = old.@state;
					}
					break;
				case (int) NodeTypes.@ProcessInstance:
					// copy attributes for: ProcessInstance
					{
						GRGEN_MODEL.IProcessInstance old = (GRGEN_MODEL.IProcessInstance) oldNode;
						newNode.@state = old.@state;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node VisibleProcessInstance ***

	public interface IVisibleProcessInstance : IAbstrProcessInstance
	{
	}

	public sealed class @VisibleProcessInstance : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IVisibleProcessInstance
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@VisibleProcessInstance[] pool = new GRGEN_MODEL.@VisibleProcessInstance[10];
		
		// explicit initializations of AbstrProcessInstance for target VisibleProcessInstance
		// implicit initializations of AbstrProcessInstance for target VisibleProcessInstance
		// explicit initializations of VisibleProcessInstance for target VisibleProcessInstance
		// implicit initializations of VisibleProcessInstance for target VisibleProcessInstance
		static @VisibleProcessInstance() {
		}
		
		public @VisibleProcessInstance() : base(GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar)
		{
			// implicit initialization, map/set creation of VisibleProcessInstance
			// explicit initializations of AbstrProcessInstance for target VisibleProcessInstance
			// explicit initializations of VisibleProcessInstance for target VisibleProcessInstance
		}

		public static GRGEN_MODEL.NodeType_VisibleProcessInstance TypeInstance { get { return GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@VisibleProcessInstance(this); }

		private @VisibleProcessInstance(GRGEN_MODEL.@VisibleProcessInstance oldElem) : base(GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar)
		{
			state\u0303 = oldElem.state\u0303;
		}
		public static GRGEN_MODEL.@VisibleProcessInstance CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@VisibleProcessInstance node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@VisibleProcessInstance();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of VisibleProcessInstance
				node.@state = 0;
				// explicit initializations of AbstrProcessInstance for target VisibleProcessInstance
				// explicit initializations of VisibleProcessInstance for target VisibleProcessInstance
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@VisibleProcessInstance CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@VisibleProcessInstance node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@VisibleProcessInstance();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of VisibleProcessInstance
				node.@state = 0;
				// explicit initializations of AbstrProcessInstance for target VisibleProcessInstance
				// explicit initializations of VisibleProcessInstance for target VisibleProcessInstance
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private GRGEN_MODEL.ENUM_PIstate state\u0303;
		public GRGEN_MODEL.ENUM_PIstate @state
		{
			get { return state\u0303; }
			set { state\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "state": return this.@state;
			}
			throw new NullReferenceException(
				"The node type \"VisibleProcessInstance\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "state": this.@state = (GRGEN_MODEL.ENUM_PIstate) value; return;
			}
			throw new NullReferenceException(
				"The node type \"VisibleProcessInstance\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of VisibleProcessInstance
			this.@state = 0;
			// explicit initializations of AbstrProcessInstance for target VisibleProcessInstance
			// explicit initializations of VisibleProcessInstance for target VisibleProcessInstance
		}
	}

	public sealed class NodeType_VisibleProcessInstance : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_VisibleProcessInstance typeVar = new GRGEN_MODEL.NodeType_VisibleProcessInstance();
		public static bool[] isA = new bool[] { true, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_VisibleProcessInstance() : base((int) NodeTypes.@VisibleProcessInstance)
		{
		}
		public override string Name { get { return "VisibleProcessInstance"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IVisibleProcessInstance"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@VisibleProcessInstance"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@VisibleProcessInstance();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_AbstrProcessInstance.AttributeType_state;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "state" : return GRGEN_MODEL.NodeType_AbstrProcessInstance.AttributeType_state;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@VisibleProcessInstance newNode = new GRGEN_MODEL.@VisibleProcessInstance();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@AbstrProcessInstance:
				case (int) NodeTypes.@ProcessInstance:
					// copy attributes for: AbstrProcessInstance
					{
						GRGEN_MODEL.IAbstrProcessInstance old = (GRGEN_MODEL.IAbstrProcessInstance) oldNode;
						newNode.@state = old.@state;
					}
					break;
				case (int) NodeTypes.@VisibleProcessInstance:
					// copy attributes for: VisibleProcessInstance
					{
						GRGEN_MODEL.IVisibleProcessInstance old = (GRGEN_MODEL.IVisibleProcessInstance) oldNode;
						newNode.@state = old.@state;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node BaseElement ***

	public interface IBaseElement : GRGEN_LIBGR.INode
	{
	}

	public sealed class NodeType_BaseElement : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BaseElement typeVar = new GRGEN_MODEL.NodeType_BaseElement();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, true, false, false, false, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, false, false, false, false, false, false, };
		public NodeType_BaseElement() : base((int) NodeTypes.@BaseElement)
		{
		}
		public override string Name { get { return "BaseElement"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IBaseElement"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type BaseElement cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type BaseElement!");
		}
	}

	// *** Node FlowElement ***

	public interface IFlowElement : IBaseElement
	{
	}

	public sealed class NodeType_FlowElement : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_FlowElement typeVar = new GRGEN_MODEL.NodeType_FlowElement();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, true, true, true, true, true, true, true, true, true, false, true, false, false, false, false, false, false, };
		public NodeType_FlowElement() : base((int) NodeTypes.@FlowElement)
		{
		}
		public override string Name { get { return "FlowElement"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IFlowElement"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type FlowElement cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type FlowElement!");
		}
	}

	// *** Node FlowElementsContainer ***

	public interface IFlowElementsContainer : IBaseElement
	{
	}

	public sealed class NodeType_FlowElementsContainer : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_FlowElementsContainer typeVar = new GRGEN_MODEL.NodeType_FlowElementsContainer();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_FlowElementsContainer() : base((int) NodeTypes.@FlowElementsContainer)
		{
		}
		public override string Name { get { return "FlowElementsContainer"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IFlowElementsContainer"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type FlowElementsContainer cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type FlowElementsContainer!");
		}
	}

	// *** Node Activity ***

	public interface IActivity : IFlowElement
	{
		string @Name { get; set; }
		int @_nOut { get; set; }
	}

	public sealed class @Activity : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IActivity
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Activity[] pool = new GRGEN_MODEL.@Activity[10];
		
		// explicit initializations of BaseElement for target Activity
		// implicit initializations of BaseElement for target Activity
		// explicit initializations of FlowElement for target Activity
		// implicit initializations of FlowElement for target Activity
		// explicit initializations of Activity for target Activity
		// implicit initializations of Activity for target Activity
		static @Activity() {
		}
		
		public @Activity() : base(GRGEN_MODEL.NodeType_Activity.typeVar)
		{
			// implicit initialization, map/set creation of Activity
			// explicit initializations of BaseElement for target Activity
			// explicit initializations of FlowElement for target Activity
			// explicit initializations of Activity for target Activity
		}

		public static GRGEN_MODEL.NodeType_Activity TypeInstance { get { return GRGEN_MODEL.NodeType_Activity.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Activity(this); }

		private @Activity(GRGEN_MODEL.@Activity oldElem) : base(GRGEN_MODEL.NodeType_Activity.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
		}
		public static GRGEN_MODEL.@Activity CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Activity node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Activity();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Activity
				node.@Name = null;
				node.@_nOut = 0;
				// explicit initializations of BaseElement for target Activity
				// explicit initializations of FlowElement for target Activity
				// explicit initializations of Activity for target Activity
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Activity CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@Activity node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Activity();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Activity
				node.@Name = null;
				node.@_nOut = 0;
				// explicit initializations of BaseElement for target Activity
				// explicit initializations of FlowElement for target Activity
				// explicit initializations of Activity for target Activity
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
			}
			throw new NullReferenceException(
				"The node type \"Activity\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
			}
			throw new NullReferenceException(
				"The node type \"Activity\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Activity
			this.@Name = null;
			this.@_nOut = 0;
			// explicit initializations of BaseElement for target Activity
			// explicit initializations of FlowElement for target Activity
			// explicit initializations of Activity for target Activity
		}
	}

	public sealed class NodeType_Activity : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Activity typeVar = new GRGEN_MODEL.NodeType_Activity();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_Name;
		public static GRGEN_LIBGR.AttributeType AttributeType__nOut;
		public NodeType_Activity() : base((int) NodeTypes.@Activity)
		{
			AttributeType_Name = new GRGEN_LIBGR.AttributeType("Name", this, GRGEN_LIBGR.AttributeKind.StringAttr, null, null, null, null);
			AttributeType__nOut = new GRGEN_LIBGR.AttributeType("_nOut", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null);
		}
		public override string Name { get { return "Activity"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IActivity"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Activity"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Activity();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_Name;
				yield return AttributeType__nOut;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return AttributeType_Name;
				case "_nOut" : return AttributeType__nOut;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Activity newNode = new GRGEN_MODEL.@Activity();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@EndEvent:
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node LoopCharacteristics ***

	public interface ILoopCharacteristics : GRGEN_LIBGR.INode
	{
	}

	public sealed class NodeType_LoopCharacteristics : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_LoopCharacteristics typeVar = new GRGEN_MODEL.NodeType_LoopCharacteristics();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_LoopCharacteristics() : base((int) NodeTypes.@LoopCharacteristics)
		{
		}
		public override string Name { get { return "LoopCharacteristics"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ILoopCharacteristics"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type LoopCharacteristics cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type LoopCharacteristics!");
		}
	}

	// *** Node StandardLoopCharacteristics ***

	public interface IStandardLoopCharacteristics : ILoopCharacteristics
	{
		bool @TestBefore { get; set; }
	}

	public sealed class @StandardLoopCharacteristics : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IStandardLoopCharacteristics
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@StandardLoopCharacteristics[] pool = new GRGEN_MODEL.@StandardLoopCharacteristics[10];
		
		// explicit initializations of LoopCharacteristics for target StandardLoopCharacteristics
		// implicit initializations of LoopCharacteristics for target StandardLoopCharacteristics
		// explicit initializations of StandardLoopCharacteristics for target StandardLoopCharacteristics
		// implicit initializations of StandardLoopCharacteristics for target StandardLoopCharacteristics
		static @StandardLoopCharacteristics() {
		}
		
		public @StandardLoopCharacteristics() : base(GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar)
		{
			// implicit initialization, map/set creation of StandardLoopCharacteristics
			// explicit initializations of LoopCharacteristics for target StandardLoopCharacteristics
			// explicit initializations of StandardLoopCharacteristics for target StandardLoopCharacteristics
		}

		public static GRGEN_MODEL.NodeType_StandardLoopCharacteristics TypeInstance { get { return GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@StandardLoopCharacteristics(this); }

		private @StandardLoopCharacteristics(GRGEN_MODEL.@StandardLoopCharacteristics oldElem) : base(GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar)
		{
			TestBefore\u0303 = oldElem.TestBefore\u0303;
		}
		public static GRGEN_MODEL.@StandardLoopCharacteristics CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@StandardLoopCharacteristics node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@StandardLoopCharacteristics();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of StandardLoopCharacteristics
				node.@TestBefore = false;
				// explicit initializations of LoopCharacteristics for target StandardLoopCharacteristics
				// explicit initializations of StandardLoopCharacteristics for target StandardLoopCharacteristics
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@StandardLoopCharacteristics CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@StandardLoopCharacteristics node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@StandardLoopCharacteristics();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of StandardLoopCharacteristics
				node.@TestBefore = false;
				// explicit initializations of LoopCharacteristics for target StandardLoopCharacteristics
				// explicit initializations of StandardLoopCharacteristics for target StandardLoopCharacteristics
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private bool TestBefore\u0303;
		public bool @TestBefore
		{
			get { return TestBefore\u0303; }
			set { TestBefore\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "TestBefore": return this.@TestBefore;
			}
			throw new NullReferenceException(
				"The node type \"StandardLoopCharacteristics\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "TestBefore": this.@TestBefore = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"StandardLoopCharacteristics\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of StandardLoopCharacteristics
			this.@TestBefore = false;
			// explicit initializations of LoopCharacteristics for target StandardLoopCharacteristics
			// explicit initializations of StandardLoopCharacteristics for target StandardLoopCharacteristics
		}
	}

	public sealed class NodeType_StandardLoopCharacteristics : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_StandardLoopCharacteristics typeVar = new GRGEN_MODEL.NodeType_StandardLoopCharacteristics();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_TestBefore;
		public NodeType_StandardLoopCharacteristics() : base((int) NodeTypes.@StandardLoopCharacteristics)
		{
			AttributeType_TestBefore = new GRGEN_LIBGR.AttributeType("TestBefore", this, GRGEN_LIBGR.AttributeKind.BooleanAttr, null, null, null, null);
		}
		public override string Name { get { return "StandardLoopCharacteristics"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IStandardLoopCharacteristics"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@StandardLoopCharacteristics"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@StandardLoopCharacteristics();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_TestBefore;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "TestBefore" : return AttributeType_TestBefore;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@StandardLoopCharacteristics newNode = new GRGEN_MODEL.@StandardLoopCharacteristics();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@StandardLoopCharacteristics:
					// copy attributes for: StandardLoopCharacteristics
					{
						GRGEN_MODEL.IStandardLoopCharacteristics old = (GRGEN_MODEL.IStandardLoopCharacteristics) oldNode;
						newNode.@TestBefore = old.@TestBefore;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node MultipleInstanceLoopCharacteristics ***

	public interface IMultipleInstanceLoopCharacteristics : ILoopCharacteristics
	{
		bool @isSequential { get; set; }
	}

	public sealed class @MultipleInstanceLoopCharacteristics : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IMultipleInstanceLoopCharacteristics
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@MultipleInstanceLoopCharacteristics[] pool = new GRGEN_MODEL.@MultipleInstanceLoopCharacteristics[10];
		
		// explicit initializations of LoopCharacteristics for target MultipleInstanceLoopCharacteristics
		// implicit initializations of LoopCharacteristics for target MultipleInstanceLoopCharacteristics
		// explicit initializations of MultipleInstanceLoopCharacteristics for target MultipleInstanceLoopCharacteristics
		// implicit initializations of MultipleInstanceLoopCharacteristics for target MultipleInstanceLoopCharacteristics
		static @MultipleInstanceLoopCharacteristics() {
		}
		
		public @MultipleInstanceLoopCharacteristics() : base(GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar)
		{
			// implicit initialization, map/set creation of MultipleInstanceLoopCharacteristics
			// explicit initializations of LoopCharacteristics for target MultipleInstanceLoopCharacteristics
			// explicit initializations of MultipleInstanceLoopCharacteristics for target MultipleInstanceLoopCharacteristics
		}

		public static GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics TypeInstance { get { return GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@MultipleInstanceLoopCharacteristics(this); }

		private @MultipleInstanceLoopCharacteristics(GRGEN_MODEL.@MultipleInstanceLoopCharacteristics oldElem) : base(GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar)
		{
			isSequential\u0303 = oldElem.isSequential\u0303;
		}
		public static GRGEN_MODEL.@MultipleInstanceLoopCharacteristics CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@MultipleInstanceLoopCharacteristics node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@MultipleInstanceLoopCharacteristics();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of MultipleInstanceLoopCharacteristics
				node.@isSequential = false;
				// explicit initializations of LoopCharacteristics for target MultipleInstanceLoopCharacteristics
				// explicit initializations of MultipleInstanceLoopCharacteristics for target MultipleInstanceLoopCharacteristics
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@MultipleInstanceLoopCharacteristics CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@MultipleInstanceLoopCharacteristics node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@MultipleInstanceLoopCharacteristics();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of MultipleInstanceLoopCharacteristics
				node.@isSequential = false;
				// explicit initializations of LoopCharacteristics for target MultipleInstanceLoopCharacteristics
				// explicit initializations of MultipleInstanceLoopCharacteristics for target MultipleInstanceLoopCharacteristics
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private bool isSequential\u0303;
		public bool @isSequential
		{
			get { return isSequential\u0303; }
			set { isSequential\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "isSequential": return this.@isSequential;
			}
			throw new NullReferenceException(
				"The node type \"MultipleInstanceLoopCharacteristics\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "isSequential": this.@isSequential = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"MultipleInstanceLoopCharacteristics\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of MultipleInstanceLoopCharacteristics
			this.@isSequential = false;
			// explicit initializations of LoopCharacteristics for target MultipleInstanceLoopCharacteristics
			// explicit initializations of MultipleInstanceLoopCharacteristics for target MultipleInstanceLoopCharacteristics
		}
	}

	public sealed class NodeType_MultipleInstanceLoopCharacteristics : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics typeVar = new GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_isSequential;
		public NodeType_MultipleInstanceLoopCharacteristics() : base((int) NodeTypes.@MultipleInstanceLoopCharacteristics)
		{
			AttributeType_isSequential = new GRGEN_LIBGR.AttributeType("isSequential", this, GRGEN_LIBGR.AttributeKind.BooleanAttr, null, null, null, null);
		}
		public override string Name { get { return "MultipleInstanceLoopCharacteristics"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IMultipleInstanceLoopCharacteristics"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@MultipleInstanceLoopCharacteristics"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@MultipleInstanceLoopCharacteristics();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_isSequential;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "isSequential" : return AttributeType_isSequential;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@MultipleInstanceLoopCharacteristics newNode = new GRGEN_MODEL.@MultipleInstanceLoopCharacteristics();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@MultipleInstanceLoopCharacteristics:
					// copy attributes for: MultipleInstanceLoopCharacteristics
					{
						GRGEN_MODEL.IMultipleInstanceLoopCharacteristics old = (GRGEN_MODEL.IMultipleInstanceLoopCharacteristics) oldNode;
						newNode.@isSequential = old.@isSequential;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node AbstrToken ***

	public interface IAbstrToken : GRGEN_LIBGR.INode
	{
	}

	public sealed class @AbstrToken : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IAbstrToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@AbstrToken[] pool = new GRGEN_MODEL.@AbstrToken[10];
		
		// explicit initializations of AbstrToken for target AbstrToken
		// implicit initializations of AbstrToken for target AbstrToken
		static @AbstrToken() {
		}
		
		public @AbstrToken() : base(GRGEN_MODEL.NodeType_AbstrToken.typeVar)
		{
			// implicit initialization, map/set creation of AbstrToken
			// explicit initializations of AbstrToken for target AbstrToken
		}

		public static GRGEN_MODEL.NodeType_AbstrToken TypeInstance { get { return GRGEN_MODEL.NodeType_AbstrToken.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@AbstrToken(this); }

		private @AbstrToken(GRGEN_MODEL.@AbstrToken oldElem) : base(GRGEN_MODEL.NodeType_AbstrToken.typeVar)
		{
		}
		public static GRGEN_MODEL.@AbstrToken CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@AbstrToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@AbstrToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of AbstrToken
				// explicit initializations of AbstrToken for target AbstrToken
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@AbstrToken CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@AbstrToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@AbstrToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of AbstrToken
				// explicit initializations of AbstrToken for target AbstrToken
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"AbstrToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"AbstrToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of AbstrToken
			// explicit initializations of AbstrToken for target AbstrToken
		}
	}

	public sealed class NodeType_AbstrToken : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_AbstrToken typeVar = new GRGEN_MODEL.NodeType_AbstrToken();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, true, true, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_AbstrToken() : base((int) NodeTypes.@AbstrToken)
		{
		}
		public override string Name { get { return "AbstrToken"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IAbstrToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@AbstrToken"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@AbstrToken();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@AbstrToken();
		}

	}

	// *** Node Token ***

	public interface IToken : IAbstrToken
	{
	}

	public sealed class @Token : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Token[] pool = new GRGEN_MODEL.@Token[10];
		
		// explicit initializations of AbstrToken for target Token
		// implicit initializations of AbstrToken for target Token
		// explicit initializations of Token for target Token
		// implicit initializations of Token for target Token
		static @Token() {
		}
		
		public @Token() : base(GRGEN_MODEL.NodeType_Token.typeVar)
		{
			// implicit initialization, map/set creation of Token
			// explicit initializations of AbstrToken for target Token
			// explicit initializations of Token for target Token
		}

		public static GRGEN_MODEL.NodeType_Token TypeInstance { get { return GRGEN_MODEL.NodeType_Token.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Token(this); }

		private @Token(GRGEN_MODEL.@Token oldElem) : base(GRGEN_MODEL.NodeType_Token.typeVar)
		{
		}
		public static GRGEN_MODEL.@Token CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Token node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Token();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Token
				// explicit initializations of AbstrToken for target Token
				// explicit initializations of Token for target Token
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Token CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@Token node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Token();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Token
				// explicit initializations of AbstrToken for target Token
				// explicit initializations of Token for target Token
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"Token\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"Token\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Token
			// explicit initializations of AbstrToken for target Token
			// explicit initializations of Token for target Token
		}
	}

	public sealed class NodeType_Token : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Token typeVar = new GRGEN_MODEL.NodeType_Token();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_Token() : base((int) NodeTypes.@Token)
		{
		}
		public override string Name { get { return "Token"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Token"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Token();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@Token();
		}

	}

	// *** Node HiddenElement ***

	public interface IHiddenElement : GRGEN_LIBGR.INode
	{
	}

	public sealed class NodeType_HiddenElement : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_HiddenElement typeVar = new GRGEN_MODEL.NodeType_HiddenElement();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_HiddenElement() : base((int) NodeTypes.@HiddenElement)
		{
		}
		public override string Name { get { return "HiddenElement"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IHiddenElement"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type HiddenElement cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type HiddenElement!");
		}
	}

	// *** Node HiddenToken ***

	public interface IHiddenToken : IAbstrToken, IHiddenElement
	{
	}

	public sealed class @HiddenToken : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IHiddenToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@HiddenToken[] pool = new GRGEN_MODEL.@HiddenToken[10];
		
		// explicit initializations of AbstrToken for target HiddenToken
		// implicit initializations of AbstrToken for target HiddenToken
		// explicit initializations of HiddenElement for target HiddenToken
		// implicit initializations of HiddenElement for target HiddenToken
		// explicit initializations of HiddenToken for target HiddenToken
		// implicit initializations of HiddenToken for target HiddenToken
		static @HiddenToken() {
		}
		
		public @HiddenToken() : base(GRGEN_MODEL.NodeType_HiddenToken.typeVar)
		{
			// implicit initialization, map/set creation of HiddenToken
			// explicit initializations of AbstrToken for target HiddenToken
			// explicit initializations of HiddenElement for target HiddenToken
			// explicit initializations of HiddenToken for target HiddenToken
		}

		public static GRGEN_MODEL.NodeType_HiddenToken TypeInstance { get { return GRGEN_MODEL.NodeType_HiddenToken.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@HiddenToken(this); }

		private @HiddenToken(GRGEN_MODEL.@HiddenToken oldElem) : base(GRGEN_MODEL.NodeType_HiddenToken.typeVar)
		{
		}
		public static GRGEN_MODEL.@HiddenToken CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@HiddenToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HiddenToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HiddenToken
				// explicit initializations of AbstrToken for target HiddenToken
				// explicit initializations of HiddenElement for target HiddenToken
				// explicit initializations of HiddenToken for target HiddenToken
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@HiddenToken CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@HiddenToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HiddenToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HiddenToken
				// explicit initializations of AbstrToken for target HiddenToken
				// explicit initializations of HiddenElement for target HiddenToken
				// explicit initializations of HiddenToken for target HiddenToken
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"HiddenToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"HiddenToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of HiddenToken
			// explicit initializations of AbstrToken for target HiddenToken
			// explicit initializations of HiddenElement for target HiddenToken
			// explicit initializations of HiddenToken for target HiddenToken
		}
	}

	public sealed class NodeType_HiddenToken : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_HiddenToken typeVar = new GRGEN_MODEL.NodeType_HiddenToken();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_HiddenToken() : base((int) NodeTypes.@HiddenToken)
		{
		}
		public override string Name { get { return "HiddenToken"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IHiddenToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@HiddenToken"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@HiddenToken();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@HiddenToken();
		}

	}

	// *** Node HiddenHistoryToken ***

	public interface IHiddenHistoryToken : IAbstrToken, IHiddenElement
	{
	}

	public sealed class @HiddenHistoryToken : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IHiddenHistoryToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@HiddenHistoryToken[] pool = new GRGEN_MODEL.@HiddenHistoryToken[10];
		
		// explicit initializations of AbstrToken for target HiddenHistoryToken
		// implicit initializations of AbstrToken for target HiddenHistoryToken
		// explicit initializations of HiddenElement for target HiddenHistoryToken
		// implicit initializations of HiddenElement for target HiddenHistoryToken
		// explicit initializations of HiddenHistoryToken for target HiddenHistoryToken
		// implicit initializations of HiddenHistoryToken for target HiddenHistoryToken
		static @HiddenHistoryToken() {
		}
		
		public @HiddenHistoryToken() : base(GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar)
		{
			// implicit initialization, map/set creation of HiddenHistoryToken
			// explicit initializations of AbstrToken for target HiddenHistoryToken
			// explicit initializations of HiddenElement for target HiddenHistoryToken
			// explicit initializations of HiddenHistoryToken for target HiddenHistoryToken
		}

		public static GRGEN_MODEL.NodeType_HiddenHistoryToken TypeInstance { get { return GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@HiddenHistoryToken(this); }

		private @HiddenHistoryToken(GRGEN_MODEL.@HiddenHistoryToken oldElem) : base(GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar)
		{
		}
		public static GRGEN_MODEL.@HiddenHistoryToken CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@HiddenHistoryToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HiddenHistoryToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HiddenHistoryToken
				// explicit initializations of AbstrToken for target HiddenHistoryToken
				// explicit initializations of HiddenElement for target HiddenHistoryToken
				// explicit initializations of HiddenHistoryToken for target HiddenHistoryToken
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@HiddenHistoryToken CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@HiddenHistoryToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HiddenHistoryToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HiddenHistoryToken
				// explicit initializations of AbstrToken for target HiddenHistoryToken
				// explicit initializations of HiddenElement for target HiddenHistoryToken
				// explicit initializations of HiddenHistoryToken for target HiddenHistoryToken
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"HiddenHistoryToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"HiddenHistoryToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of HiddenHistoryToken
			// explicit initializations of AbstrToken for target HiddenHistoryToken
			// explicit initializations of HiddenElement for target HiddenHistoryToken
			// explicit initializations of HiddenHistoryToken for target HiddenHistoryToken
		}
	}

	public sealed class NodeType_HiddenHistoryToken : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_HiddenHistoryToken typeVar = new GRGEN_MODEL.NodeType_HiddenHistoryToken();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_HiddenHistoryToken() : base((int) NodeTypes.@HiddenHistoryToken)
		{
		}
		public override string Name { get { return "HiddenHistoryToken"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IHiddenHistoryToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@HiddenHistoryToken"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@HiddenHistoryToken();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@HiddenHistoryToken();
		}

	}

	// *** Node HiddenUndoToken ***

	public interface IHiddenUndoToken : IAbstrToken, IHiddenElement
	{
	}

	public sealed class @HiddenUndoToken : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IHiddenUndoToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@HiddenUndoToken[] pool = new GRGEN_MODEL.@HiddenUndoToken[10];
		
		// explicit initializations of AbstrToken for target HiddenUndoToken
		// implicit initializations of AbstrToken for target HiddenUndoToken
		// explicit initializations of HiddenElement for target HiddenUndoToken
		// implicit initializations of HiddenElement for target HiddenUndoToken
		// explicit initializations of HiddenUndoToken for target HiddenUndoToken
		// implicit initializations of HiddenUndoToken for target HiddenUndoToken
		static @HiddenUndoToken() {
		}
		
		public @HiddenUndoToken() : base(GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar)
		{
			// implicit initialization, map/set creation of HiddenUndoToken
			// explicit initializations of AbstrToken for target HiddenUndoToken
			// explicit initializations of HiddenElement for target HiddenUndoToken
			// explicit initializations of HiddenUndoToken for target HiddenUndoToken
		}

		public static GRGEN_MODEL.NodeType_HiddenUndoToken TypeInstance { get { return GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@HiddenUndoToken(this); }

		private @HiddenUndoToken(GRGEN_MODEL.@HiddenUndoToken oldElem) : base(GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar)
		{
		}
		public static GRGEN_MODEL.@HiddenUndoToken CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@HiddenUndoToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HiddenUndoToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HiddenUndoToken
				// explicit initializations of AbstrToken for target HiddenUndoToken
				// explicit initializations of HiddenElement for target HiddenUndoToken
				// explicit initializations of HiddenUndoToken for target HiddenUndoToken
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@HiddenUndoToken CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@HiddenUndoToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HiddenUndoToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HiddenUndoToken
				// explicit initializations of AbstrToken for target HiddenUndoToken
				// explicit initializations of HiddenElement for target HiddenUndoToken
				// explicit initializations of HiddenUndoToken for target HiddenUndoToken
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"HiddenUndoToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"HiddenUndoToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of HiddenUndoToken
			// explicit initializations of AbstrToken for target HiddenUndoToken
			// explicit initializations of HiddenElement for target HiddenUndoToken
			// explicit initializations of HiddenUndoToken for target HiddenUndoToken
		}
	}

	public sealed class NodeType_HiddenUndoToken : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_HiddenUndoToken typeVar = new GRGEN_MODEL.NodeType_HiddenUndoToken();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_HiddenUndoToken() : base((int) NodeTypes.@HiddenUndoToken)
		{
		}
		public override string Name { get { return "HiddenUndoToken"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IHiddenUndoToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@HiddenUndoToken"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@HiddenUndoToken();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@HiddenUndoToken();
		}

	}

	// *** Node HiddenUndoneToken ***

	public interface IHiddenUndoneToken : IAbstrToken, IHiddenElement
	{
	}

	public sealed class @HiddenUndoneToken : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IHiddenUndoneToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@HiddenUndoneToken[] pool = new GRGEN_MODEL.@HiddenUndoneToken[10];
		
		// explicit initializations of AbstrToken for target HiddenUndoneToken
		// implicit initializations of AbstrToken for target HiddenUndoneToken
		// explicit initializations of HiddenElement for target HiddenUndoneToken
		// implicit initializations of HiddenElement for target HiddenUndoneToken
		// explicit initializations of HiddenUndoneToken for target HiddenUndoneToken
		// implicit initializations of HiddenUndoneToken for target HiddenUndoneToken
		static @HiddenUndoneToken() {
		}
		
		public @HiddenUndoneToken() : base(GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar)
		{
			// implicit initialization, map/set creation of HiddenUndoneToken
			// explicit initializations of AbstrToken for target HiddenUndoneToken
			// explicit initializations of HiddenElement for target HiddenUndoneToken
			// explicit initializations of HiddenUndoneToken for target HiddenUndoneToken
		}

		public static GRGEN_MODEL.NodeType_HiddenUndoneToken TypeInstance { get { return GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@HiddenUndoneToken(this); }

		private @HiddenUndoneToken(GRGEN_MODEL.@HiddenUndoneToken oldElem) : base(GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar)
		{
		}
		public static GRGEN_MODEL.@HiddenUndoneToken CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@HiddenUndoneToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HiddenUndoneToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HiddenUndoneToken
				// explicit initializations of AbstrToken for target HiddenUndoneToken
				// explicit initializations of HiddenElement for target HiddenUndoneToken
				// explicit initializations of HiddenUndoneToken for target HiddenUndoneToken
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@HiddenUndoneToken CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@HiddenUndoneToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HiddenUndoneToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HiddenUndoneToken
				// explicit initializations of AbstrToken for target HiddenUndoneToken
				// explicit initializations of HiddenElement for target HiddenUndoneToken
				// explicit initializations of HiddenUndoneToken for target HiddenUndoneToken
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"HiddenUndoneToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"HiddenUndoneToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of HiddenUndoneToken
			// explicit initializations of AbstrToken for target HiddenUndoneToken
			// explicit initializations of HiddenElement for target HiddenUndoneToken
			// explicit initializations of HiddenUndoneToken for target HiddenUndoneToken
		}
	}

	public sealed class NodeType_HiddenUndoneToken : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_HiddenUndoneToken typeVar = new GRGEN_MODEL.NodeType_HiddenUndoneToken();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_HiddenUndoneToken() : base((int) NodeTypes.@HiddenUndoneToken)
		{
		}
		public override string Name { get { return "HiddenUndoneToken"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IHiddenUndoneToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@HiddenUndoneToken"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@HiddenUndoneToken();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@HiddenUndoneToken();
		}

	}

	// *** Node HistoryToken ***

	public interface IHistoryToken : IAbstrToken
	{
	}

	public sealed class @HistoryToken : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IHistoryToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@HistoryToken[] pool = new GRGEN_MODEL.@HistoryToken[10];
		
		// explicit initializations of AbstrToken for target HistoryToken
		// implicit initializations of AbstrToken for target HistoryToken
		// explicit initializations of HistoryToken for target HistoryToken
		// implicit initializations of HistoryToken for target HistoryToken
		static @HistoryToken() {
		}
		
		public @HistoryToken() : base(GRGEN_MODEL.NodeType_HistoryToken.typeVar)
		{
			// implicit initialization, map/set creation of HistoryToken
			// explicit initializations of AbstrToken for target HistoryToken
			// explicit initializations of HistoryToken for target HistoryToken
		}

		public static GRGEN_MODEL.NodeType_HistoryToken TypeInstance { get { return GRGEN_MODEL.NodeType_HistoryToken.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@HistoryToken(this); }

		private @HistoryToken(GRGEN_MODEL.@HistoryToken oldElem) : base(GRGEN_MODEL.NodeType_HistoryToken.typeVar)
		{
		}
		public static GRGEN_MODEL.@HistoryToken CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@HistoryToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HistoryToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HistoryToken
				// explicit initializations of AbstrToken for target HistoryToken
				// explicit initializations of HistoryToken for target HistoryToken
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@HistoryToken CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@HistoryToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HistoryToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HistoryToken
				// explicit initializations of AbstrToken for target HistoryToken
				// explicit initializations of HistoryToken for target HistoryToken
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"HistoryToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"HistoryToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of HistoryToken
			// explicit initializations of AbstrToken for target HistoryToken
			// explicit initializations of HistoryToken for target HistoryToken
		}
	}

	public sealed class NodeType_HistoryToken : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_HistoryToken typeVar = new GRGEN_MODEL.NodeType_HistoryToken();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_HistoryToken() : base((int) NodeTypes.@HistoryToken)
		{
		}
		public override string Name { get { return "HistoryToken"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IHistoryToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@HistoryToken"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@HistoryToken();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@HistoryToken();
		}

	}

	// *** Node UndoToken ***

	public interface IUndoToken : IAbstrToken
	{
	}

	public sealed class @UndoToken : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IUndoToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@UndoToken[] pool = new GRGEN_MODEL.@UndoToken[10];
		
		// explicit initializations of AbstrToken for target UndoToken
		// implicit initializations of AbstrToken for target UndoToken
		// explicit initializations of UndoToken for target UndoToken
		// implicit initializations of UndoToken for target UndoToken
		static @UndoToken() {
		}
		
		public @UndoToken() : base(GRGEN_MODEL.NodeType_UndoToken.typeVar)
		{
			// implicit initialization, map/set creation of UndoToken
			// explicit initializations of AbstrToken for target UndoToken
			// explicit initializations of UndoToken for target UndoToken
		}

		public static GRGEN_MODEL.NodeType_UndoToken TypeInstance { get { return GRGEN_MODEL.NodeType_UndoToken.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@UndoToken(this); }

		private @UndoToken(GRGEN_MODEL.@UndoToken oldElem) : base(GRGEN_MODEL.NodeType_UndoToken.typeVar)
		{
		}
		public static GRGEN_MODEL.@UndoToken CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@UndoToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@UndoToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of UndoToken
				// explicit initializations of AbstrToken for target UndoToken
				// explicit initializations of UndoToken for target UndoToken
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@UndoToken CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@UndoToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@UndoToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of UndoToken
				// explicit initializations of AbstrToken for target UndoToken
				// explicit initializations of UndoToken for target UndoToken
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"UndoToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"UndoToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of UndoToken
			// explicit initializations of AbstrToken for target UndoToken
			// explicit initializations of UndoToken for target UndoToken
		}
	}

	public sealed class NodeType_UndoToken : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_UndoToken typeVar = new GRGEN_MODEL.NodeType_UndoToken();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_UndoToken() : base((int) NodeTypes.@UndoToken)
		{
		}
		public override string Name { get { return "UndoToken"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IUndoToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@UndoToken"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@UndoToken();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@UndoToken();
		}

	}

	// *** Node UndoneToken ***

	public interface IUndoneToken : IAbstrToken
	{
	}

	public sealed class @UndoneToken : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IUndoneToken
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@UndoneToken[] pool = new GRGEN_MODEL.@UndoneToken[10];
		
		// explicit initializations of AbstrToken for target UndoneToken
		// implicit initializations of AbstrToken for target UndoneToken
		// explicit initializations of UndoneToken for target UndoneToken
		// implicit initializations of UndoneToken for target UndoneToken
		static @UndoneToken() {
		}
		
		public @UndoneToken() : base(GRGEN_MODEL.NodeType_UndoneToken.typeVar)
		{
			// implicit initialization, map/set creation of UndoneToken
			// explicit initializations of AbstrToken for target UndoneToken
			// explicit initializations of UndoneToken for target UndoneToken
		}

		public static GRGEN_MODEL.NodeType_UndoneToken TypeInstance { get { return GRGEN_MODEL.NodeType_UndoneToken.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@UndoneToken(this); }

		private @UndoneToken(GRGEN_MODEL.@UndoneToken oldElem) : base(GRGEN_MODEL.NodeType_UndoneToken.typeVar)
		{
		}
		public static GRGEN_MODEL.@UndoneToken CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@UndoneToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@UndoneToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of UndoneToken
				// explicit initializations of AbstrToken for target UndoneToken
				// explicit initializations of UndoneToken for target UndoneToken
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@UndoneToken CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@UndoneToken node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@UndoneToken();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of UndoneToken
				// explicit initializations of AbstrToken for target UndoneToken
				// explicit initializations of UndoneToken for target UndoneToken
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"UndoneToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"UndoneToken\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of UndoneToken
			// explicit initializations of AbstrToken for target UndoneToken
			// explicit initializations of UndoneToken for target UndoneToken
		}
	}

	public sealed class NodeType_UndoneToken : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_UndoneToken typeVar = new GRGEN_MODEL.NodeType_UndoneToken();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_UndoneToken() : base((int) NodeTypes.@UndoneToken)
		{
		}
		public override string Name { get { return "UndoneToken"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IUndoneToken"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@UndoneToken"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@UndoneToken();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@UndoneToken();
		}

	}

	// *** Node PException ***

	public interface IPException : GRGEN_LIBGR.INode
	{
	}

	public sealed class @PException : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IPException
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@PException[] pool = new GRGEN_MODEL.@PException[10];
		
		// explicit initializations of PException for target PException
		// implicit initializations of PException for target PException
		static @PException() {
		}
		
		public @PException() : base(GRGEN_MODEL.NodeType_PException.typeVar)
		{
			// implicit initialization, map/set creation of PException
			// explicit initializations of PException for target PException
		}

		public static GRGEN_MODEL.NodeType_PException TypeInstance { get { return GRGEN_MODEL.NodeType_PException.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@PException(this); }

		private @PException(GRGEN_MODEL.@PException oldElem) : base(GRGEN_MODEL.NodeType_PException.typeVar)
		{
		}
		public static GRGEN_MODEL.@PException CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@PException node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@PException();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of PException
				// explicit initializations of PException for target PException
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@PException CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@PException node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@PException();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of PException
				// explicit initializations of PException for target PException
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"PException\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"PException\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of PException
			// explicit initializations of PException for target PException
		}
	}

	public sealed class NodeType_PException : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_PException typeVar = new GRGEN_MODEL.NodeType_PException();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_PException() : base((int) NodeTypes.@PException)
		{
		}
		public override string Name { get { return "PException"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IPException"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@PException"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@PException();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@PException();
		}

	}

	// *** Node Task ***

	public interface ITask : IActivity
	{
	}

	public sealed class @Task : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.ITask
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Task[] pool = new GRGEN_MODEL.@Task[10];
		
		// explicit initializations of BaseElement for target Task
		// implicit initializations of BaseElement for target Task
		// explicit initializations of FlowElement for target Task
		// implicit initializations of FlowElement for target Task
		// explicit initializations of Activity for target Task
		// implicit initializations of Activity for target Task
		// explicit initializations of Task for target Task
		// implicit initializations of Task for target Task
		static @Task() {
		}
		
		public @Task() : base(GRGEN_MODEL.NodeType_Task.typeVar)
		{
			// implicit initialization, map/set creation of Task
			// explicit initializations of BaseElement for target Task
			// explicit initializations of FlowElement for target Task
			// explicit initializations of Activity for target Task
			// explicit initializations of Task for target Task
		}

		public static GRGEN_MODEL.NodeType_Task TypeInstance { get { return GRGEN_MODEL.NodeType_Task.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Task(this); }

		private @Task(GRGEN_MODEL.@Task oldElem) : base(GRGEN_MODEL.NodeType_Task.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
		}
		public static GRGEN_MODEL.@Task CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Task node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Task();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Task
				node.@Name = null;
				node.@_nOut = 0;
				// explicit initializations of BaseElement for target Task
				// explicit initializations of FlowElement for target Task
				// explicit initializations of Activity for target Task
				// explicit initializations of Task for target Task
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Task CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@Task node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Task();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Task
				node.@Name = null;
				node.@_nOut = 0;
				// explicit initializations of BaseElement for target Task
				// explicit initializations of FlowElement for target Task
				// explicit initializations of Activity for target Task
				// explicit initializations of Task for target Task
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
			}
			throw new NullReferenceException(
				"The node type \"Task\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
			}
			throw new NullReferenceException(
				"The node type \"Task\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Task
			this.@Name = null;
			this.@_nOut = 0;
			// explicit initializations of BaseElement for target Task
			// explicit initializations of FlowElement for target Task
			// explicit initializations of Activity for target Task
			// explicit initializations of Task for target Task
		}
	}

	public sealed class NodeType_Task : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Task typeVar = new GRGEN_MODEL.NodeType_Task();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_Task() : base((int) NodeTypes.@Task)
		{
		}
		public override string Name { get { return "Task"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ITask"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Task"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Task();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Task newNode = new GRGEN_MODEL.@Task();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@EndEvent:
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@Task:
					// copy attributes for: Task
					{
						GRGEN_MODEL.ITask old = (GRGEN_MODEL.ITask) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node Event ***

	public interface IEvent : IActivity
	{
		string @EventDefinitionName { get; set; }
		string @ErrorCode { get; set; }
		GRGEN_MODEL.ENUM_TriggerType @Trigger { get; set; }
		GRGEN_MODEL.ENUM_TriggerType @Result { get; set; }
		bool @cancelActivity { get; set; }
	}

	public sealed class @Event : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IEvent
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Event[] pool = new GRGEN_MODEL.@Event[10];
		
		// explicit initializations of BaseElement for target Event
		// implicit initializations of BaseElement for target Event
		// explicit initializations of FlowElement for target Event
		// implicit initializations of FlowElement for target Event
		// explicit initializations of Activity for target Event
		// implicit initializations of Activity for target Event
		// explicit initializations of Event for target Event
		// implicit initializations of Event for target Event
		static @Event() {
		}
		
		public @Event() : base(GRGEN_MODEL.NodeType_Event.typeVar)
		{
			// implicit initialization, map/set creation of Event
			// explicit initializations of BaseElement for target Event
			// explicit initializations of FlowElement for target Event
			// explicit initializations of Activity for target Event
			// explicit initializations of Event for target Event
		}

		public static GRGEN_MODEL.NodeType_Event TypeInstance { get { return GRGEN_MODEL.NodeType_Event.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Event(this); }

		private @Event(GRGEN_MODEL.@Event oldElem) : base(GRGEN_MODEL.NodeType_Event.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
			EventDefinitionName\u0303 = oldElem.EventDefinitionName\u0303;
			ErrorCode\u0303 = oldElem.ErrorCode\u0303;
			Trigger\u0303 = oldElem.Trigger\u0303;
			Result\u0303 = oldElem.Result\u0303;
			cancelActivity\u0303 = oldElem.cancelActivity\u0303;
		}
		public static GRGEN_MODEL.@Event CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Event node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Event();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Event
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target Event
				// explicit initializations of FlowElement for target Event
				// explicit initializations of Activity for target Event
				// explicit initializations of Event for target Event
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Event CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@Event node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Event();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Event
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target Event
				// explicit initializations of FlowElement for target Event
				// explicit initializations of Activity for target Event
				// explicit initializations of Event for target Event
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}

		private string EventDefinitionName\u0303;
		public string @EventDefinitionName
		{
			get { return EventDefinitionName\u0303; }
			set { EventDefinitionName\u0303 = value; }
		}

		private string ErrorCode\u0303;
		public string @ErrorCode
		{
			get { return ErrorCode\u0303; }
			set { ErrorCode\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Trigger\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Trigger
		{
			get { return Trigger\u0303; }
			set { Trigger\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Result\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Result
		{
			get { return Result\u0303; }
			set { Result\u0303 = value; }
		}

		private bool cancelActivity\u0303;
		public bool @cancelActivity
		{
			get { return cancelActivity\u0303; }
			set { cancelActivity\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
				case "EventDefinitionName": return this.@EventDefinitionName;
				case "ErrorCode": return this.@ErrorCode;
				case "Trigger": return this.@Trigger;
				case "Result": return this.@Result;
				case "cancelActivity": return this.@cancelActivity;
			}
			throw new NullReferenceException(
				"The node type \"Event\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
				case "EventDefinitionName": this.@EventDefinitionName = (string) value; return;
				case "ErrorCode": this.@ErrorCode = (string) value; return;
				case "Trigger": this.@Trigger = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "Result": this.@Result = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "cancelActivity": this.@cancelActivity = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"Event\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Event
			this.@Name = null;
			this.@_nOut = 0;
			this.@EventDefinitionName = null;
			this.@ErrorCode = null;
			this.@Trigger = 0;
			this.@Result = 0;
			this.@cancelActivity = false;
			// explicit initializations of BaseElement for target Event
			// explicit initializations of FlowElement for target Event
			// explicit initializations of Activity for target Event
			// explicit initializations of Event for target Event
		}
	}

	public sealed class NodeType_Event : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Event typeVar = new GRGEN_MODEL.NodeType_Event();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_EventDefinitionName;
		public static GRGEN_LIBGR.AttributeType AttributeType_ErrorCode;
		public static GRGEN_LIBGR.AttributeType AttributeType_Trigger;
		public static GRGEN_LIBGR.AttributeType AttributeType_Result;
		public static GRGEN_LIBGR.AttributeType AttributeType_cancelActivity;
		public NodeType_Event() : base((int) NodeTypes.@Event)
		{
			AttributeType_EventDefinitionName = new GRGEN_LIBGR.AttributeType("EventDefinitionName", this, GRGEN_LIBGR.AttributeKind.StringAttr, null, null, null, null);
			AttributeType_ErrorCode = new GRGEN_LIBGR.AttributeType("ErrorCode", this, GRGEN_LIBGR.AttributeKind.StringAttr, null, null, null, null);
			AttributeType_Trigger = new GRGEN_LIBGR.AttributeType("Trigger", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@TriggerType, null, null, null);
			AttributeType_Result = new GRGEN_LIBGR.AttributeType("Result", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@TriggerType, null, null, null);
			AttributeType_cancelActivity = new GRGEN_LIBGR.AttributeType("cancelActivity", this, GRGEN_LIBGR.AttributeKind.BooleanAttr, null, null, null, null);
		}
		public override string Name { get { return "Event"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IEvent"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Event"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Event();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 7; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				yield return AttributeType_EventDefinitionName;
				yield return AttributeType_ErrorCode;
				yield return AttributeType_Trigger;
				yield return AttributeType_Result;
				yield return AttributeType_cancelActivity;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				case "EventDefinitionName" : return AttributeType_EventDefinitionName;
				case "ErrorCode" : return AttributeType_ErrorCode;
				case "Trigger" : return AttributeType_Trigger;
				case "Result" : return AttributeType_Result;
				case "cancelActivity" : return AttributeType_cancelActivity;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Event newNode = new GRGEN_MODEL.@Event();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@EndEvent:
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
					// copy attributes for: Event
					{
						GRGEN_MODEL.IEvent old = (GRGEN_MODEL.IEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node BlockActivity ***

	public interface IBlockActivity : IActivity, IActivitySet
	{
	}

	public sealed class @BlockActivity : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IBlockActivity
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@BlockActivity[] pool = new GRGEN_MODEL.@BlockActivity[10];
		
		// explicit initializations of BaseElement for target BlockActivity
		// implicit initializations of BaseElement for target BlockActivity
		// explicit initializations of FlowElement for target BlockActivity
		// implicit initializations of FlowElement for target BlockActivity
		// explicit initializations of Activity for target BlockActivity
		// implicit initializations of Activity for target BlockActivity
		// explicit initializations of FlowElementsContainer for target BlockActivity
		// implicit initializations of FlowElementsContainer for target BlockActivity
		// explicit initializations of ActivitySet for target BlockActivity
		// implicit initializations of ActivitySet for target BlockActivity
		// explicit initializations of BlockActivity for target BlockActivity
		// implicit initializations of BlockActivity for target BlockActivity
		static @BlockActivity() {
		}
		
		public @BlockActivity() : base(GRGEN_MODEL.NodeType_BlockActivity.typeVar)
		{
			// implicit initialization, map/set creation of BlockActivity
			// explicit initializations of BaseElement for target BlockActivity
			// explicit initializations of FlowElement for target BlockActivity
			// explicit initializations of Activity for target BlockActivity
			// explicit initializations of FlowElementsContainer for target BlockActivity
			// explicit initializations of ActivitySet for target BlockActivity
			// explicit initializations of BlockActivity for target BlockActivity
		}

		public static GRGEN_MODEL.NodeType_BlockActivity TypeInstance { get { return GRGEN_MODEL.NodeType_BlockActivity.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@BlockActivity(this); }

		private @BlockActivity(GRGEN_MODEL.@BlockActivity oldElem) : base(GRGEN_MODEL.NodeType_BlockActivity.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
		}
		public static GRGEN_MODEL.@BlockActivity CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@BlockActivity node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BlockActivity();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of BlockActivity
				node.@Name = null;
				node.@_nOut = 0;
				// explicit initializations of BaseElement for target BlockActivity
				// explicit initializations of FlowElement for target BlockActivity
				// explicit initializations of Activity for target BlockActivity
				// explicit initializations of FlowElementsContainer for target BlockActivity
				// explicit initializations of ActivitySet for target BlockActivity
				// explicit initializations of BlockActivity for target BlockActivity
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@BlockActivity CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@BlockActivity node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@BlockActivity();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of BlockActivity
				node.@Name = null;
				node.@_nOut = 0;
				// explicit initializations of BaseElement for target BlockActivity
				// explicit initializations of FlowElement for target BlockActivity
				// explicit initializations of Activity for target BlockActivity
				// explicit initializations of FlowElementsContainer for target BlockActivity
				// explicit initializations of ActivitySet for target BlockActivity
				// explicit initializations of BlockActivity for target BlockActivity
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
			}
			throw new NullReferenceException(
				"The node type \"BlockActivity\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
			}
			throw new NullReferenceException(
				"The node type \"BlockActivity\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of BlockActivity
			this.@Name = null;
			this.@_nOut = 0;
			// explicit initializations of BaseElement for target BlockActivity
			// explicit initializations of FlowElement for target BlockActivity
			// explicit initializations of Activity for target BlockActivity
			// explicit initializations of FlowElementsContainer for target BlockActivity
			// explicit initializations of ActivitySet for target BlockActivity
			// explicit initializations of BlockActivity for target BlockActivity
		}
	}

	public sealed class NodeType_BlockActivity : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_BlockActivity typeVar = new GRGEN_MODEL.NodeType_BlockActivity();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_BlockActivity() : base((int) NodeTypes.@BlockActivity)
		{
		}
		public override string Name { get { return "BlockActivity"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IBlockActivity"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@BlockActivity"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@BlockActivity();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 2; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@BlockActivity newNode = new GRGEN_MODEL.@BlockActivity();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@EndEvent:
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@BlockActivity:
					// copy attributes for: BlockActivity
					{
						GRGEN_MODEL.IBlockActivity old = (GRGEN_MODEL.IBlockActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node ActivitySet ***

	public interface IActivitySet : IFlowElementsContainer
	{
	}

	public sealed class @ActivitySet : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IActivitySet
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@ActivitySet[] pool = new GRGEN_MODEL.@ActivitySet[10];
		
		// explicit initializations of BaseElement for target ActivitySet
		// implicit initializations of BaseElement for target ActivitySet
		// explicit initializations of FlowElementsContainer for target ActivitySet
		// implicit initializations of FlowElementsContainer for target ActivitySet
		// explicit initializations of ActivitySet for target ActivitySet
		// implicit initializations of ActivitySet for target ActivitySet
		static @ActivitySet() {
		}
		
		public @ActivitySet() : base(GRGEN_MODEL.NodeType_ActivitySet.typeVar)
		{
			// implicit initialization, map/set creation of ActivitySet
			// explicit initializations of BaseElement for target ActivitySet
			// explicit initializations of FlowElementsContainer for target ActivitySet
			// explicit initializations of ActivitySet for target ActivitySet
		}

		public static GRGEN_MODEL.NodeType_ActivitySet TypeInstance { get { return GRGEN_MODEL.NodeType_ActivitySet.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@ActivitySet(this); }

		private @ActivitySet(GRGEN_MODEL.@ActivitySet oldElem) : base(GRGEN_MODEL.NodeType_ActivitySet.typeVar)
		{
		}
		public static GRGEN_MODEL.@ActivitySet CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@ActivitySet node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@ActivitySet();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of ActivitySet
				// explicit initializations of BaseElement for target ActivitySet
				// explicit initializations of FlowElementsContainer for target ActivitySet
				// explicit initializations of ActivitySet for target ActivitySet
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@ActivitySet CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@ActivitySet node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@ActivitySet();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of ActivitySet
				// explicit initializations of BaseElement for target ActivitySet
				// explicit initializations of FlowElementsContainer for target ActivitySet
				// explicit initializations of ActivitySet for target ActivitySet
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"ActivitySet\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"ActivitySet\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of ActivitySet
			// explicit initializations of BaseElement for target ActivitySet
			// explicit initializations of FlowElementsContainer for target ActivitySet
			// explicit initializations of ActivitySet for target ActivitySet
		}
	}

	public sealed class NodeType_ActivitySet : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_ActivitySet typeVar = new GRGEN_MODEL.NodeType_ActivitySet();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_ActivitySet() : base((int) NodeTypes.@ActivitySet)
		{
		}
		public override string Name { get { return "ActivitySet"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IActivitySet"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@ActivitySet"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@ActivitySet();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@ActivitySet();
		}

	}

	// *** Node StartEvent ***

	public interface IStartEvent : IEvent
	{
		bool @_triggeredAutonomously { get; set; }
	}

	public sealed class @StartEvent : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IStartEvent
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@StartEvent[] pool = new GRGEN_MODEL.@StartEvent[10];
		
		// explicit initializations of BaseElement for target StartEvent
		// implicit initializations of BaseElement for target StartEvent
		// explicit initializations of FlowElement for target StartEvent
		// implicit initializations of FlowElement for target StartEvent
		// explicit initializations of Activity for target StartEvent
		// implicit initializations of Activity for target StartEvent
		// explicit initializations of Event for target StartEvent
		// implicit initializations of Event for target StartEvent
		// explicit initializations of StartEvent for target StartEvent
		// implicit initializations of StartEvent for target StartEvent
		static @StartEvent() {
		}
		
		public @StartEvent() : base(GRGEN_MODEL.NodeType_StartEvent.typeVar)
		{
			// implicit initialization, map/set creation of StartEvent
			// explicit initializations of BaseElement for target StartEvent
			// explicit initializations of FlowElement for target StartEvent
			// explicit initializations of Activity for target StartEvent
			// explicit initializations of Event for target StartEvent
			// explicit initializations of StartEvent for target StartEvent
		}

		public static GRGEN_MODEL.NodeType_StartEvent TypeInstance { get { return GRGEN_MODEL.NodeType_StartEvent.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@StartEvent(this); }

		private @StartEvent(GRGEN_MODEL.@StartEvent oldElem) : base(GRGEN_MODEL.NodeType_StartEvent.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
			EventDefinitionName\u0303 = oldElem.EventDefinitionName\u0303;
			ErrorCode\u0303 = oldElem.ErrorCode\u0303;
			Trigger\u0303 = oldElem.Trigger\u0303;
			Result\u0303 = oldElem.Result\u0303;
			cancelActivity\u0303 = oldElem.cancelActivity\u0303;
			_triggeredAutonomously\u0303 = oldElem._triggeredAutonomously\u0303;
		}
		public static GRGEN_MODEL.@StartEvent CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@StartEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@StartEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of StartEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				node.@_triggeredAutonomously = false;
				// explicit initializations of BaseElement for target StartEvent
				// explicit initializations of FlowElement for target StartEvent
				// explicit initializations of Activity for target StartEvent
				// explicit initializations of Event for target StartEvent
				// explicit initializations of StartEvent for target StartEvent
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@StartEvent CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@StartEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@StartEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of StartEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				node.@_triggeredAutonomously = false;
				// explicit initializations of BaseElement for target StartEvent
				// explicit initializations of FlowElement for target StartEvent
				// explicit initializations of Activity for target StartEvent
				// explicit initializations of Event for target StartEvent
				// explicit initializations of StartEvent for target StartEvent
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}

		private string EventDefinitionName\u0303;
		public string @EventDefinitionName
		{
			get { return EventDefinitionName\u0303; }
			set { EventDefinitionName\u0303 = value; }
		}

		private string ErrorCode\u0303;
		public string @ErrorCode
		{
			get { return ErrorCode\u0303; }
			set { ErrorCode\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Trigger\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Trigger
		{
			get { return Trigger\u0303; }
			set { Trigger\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Result\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Result
		{
			get { return Result\u0303; }
			set { Result\u0303 = value; }
		}

		private bool cancelActivity\u0303;
		public bool @cancelActivity
		{
			get { return cancelActivity\u0303; }
			set { cancelActivity\u0303 = value; }
		}

		private bool _triggeredAutonomously\u0303;
		public bool @_triggeredAutonomously
		{
			get { return _triggeredAutonomously\u0303; }
			set { _triggeredAutonomously\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
				case "EventDefinitionName": return this.@EventDefinitionName;
				case "ErrorCode": return this.@ErrorCode;
				case "Trigger": return this.@Trigger;
				case "Result": return this.@Result;
				case "cancelActivity": return this.@cancelActivity;
				case "_triggeredAutonomously": return this.@_triggeredAutonomously;
			}
			throw new NullReferenceException(
				"The node type \"StartEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
				case "EventDefinitionName": this.@EventDefinitionName = (string) value; return;
				case "ErrorCode": this.@ErrorCode = (string) value; return;
				case "Trigger": this.@Trigger = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "Result": this.@Result = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "cancelActivity": this.@cancelActivity = (bool) value; return;
				case "_triggeredAutonomously": this.@_triggeredAutonomously = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"StartEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of StartEvent
			this.@Name = null;
			this.@_nOut = 0;
			this.@EventDefinitionName = null;
			this.@ErrorCode = null;
			this.@Trigger = 0;
			this.@Result = 0;
			this.@cancelActivity = false;
			this.@_triggeredAutonomously = false;
			// explicit initializations of BaseElement for target StartEvent
			// explicit initializations of FlowElement for target StartEvent
			// explicit initializations of Activity for target StartEvent
			// explicit initializations of Event for target StartEvent
			// explicit initializations of StartEvent for target StartEvent
		}
	}

	public sealed class NodeType_StartEvent : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_StartEvent typeVar = new GRGEN_MODEL.NodeType_StartEvent();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType__triggeredAutonomously;
		public NodeType_StartEvent() : base((int) NodeTypes.@StartEvent)
		{
			AttributeType__triggeredAutonomously = new GRGEN_LIBGR.AttributeType("_triggeredAutonomously", this, GRGEN_LIBGR.AttributeKind.BooleanAttr, null, null, null, null);
		}
		public override string Name { get { return "StartEvent"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IStartEvent"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@StartEvent"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@StartEvent();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 8; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
				yield return AttributeType__triggeredAutonomously;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				case "EventDefinitionName" : return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				case "ErrorCode" : return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				case "Trigger" : return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				case "Result" : return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				case "cancelActivity" : return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
				case "_triggeredAutonomously" : return AttributeType__triggeredAutonomously;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@StartEvent newNode = new GRGEN_MODEL.@StartEvent();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@EndEvent:
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
					// copy attributes for: Event
					{
						GRGEN_MODEL.IEvent old = (GRGEN_MODEL.IEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
				case (int) NodeTypes.@StartEvent:
					// copy attributes for: StartEvent
					{
						GRGEN_MODEL.IStartEvent old = (GRGEN_MODEL.IStartEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
						newNode.@_triggeredAutonomously = old.@_triggeredAutonomously;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node EndEvent ***

	public interface IEndEvent : IEvent
	{
	}

	public sealed class @EndEvent : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IEndEvent
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@EndEvent[] pool = new GRGEN_MODEL.@EndEvent[10];
		
		// explicit initializations of BaseElement for target EndEvent
		// implicit initializations of BaseElement for target EndEvent
		// explicit initializations of FlowElement for target EndEvent
		// implicit initializations of FlowElement for target EndEvent
		// explicit initializations of Activity for target EndEvent
		// implicit initializations of Activity for target EndEvent
		// explicit initializations of Event for target EndEvent
		// implicit initializations of Event for target EndEvent
		// explicit initializations of EndEvent for target EndEvent
		// implicit initializations of EndEvent for target EndEvent
		static @EndEvent() {
		}
		
		public @EndEvent() : base(GRGEN_MODEL.NodeType_EndEvent.typeVar)
		{
			// implicit initialization, map/set creation of EndEvent
			// explicit initializations of BaseElement for target EndEvent
			// explicit initializations of FlowElement for target EndEvent
			// explicit initializations of Activity for target EndEvent
			// explicit initializations of Event for target EndEvent
			// explicit initializations of EndEvent for target EndEvent
		}

		public static GRGEN_MODEL.NodeType_EndEvent TypeInstance { get { return GRGEN_MODEL.NodeType_EndEvent.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@EndEvent(this); }

		private @EndEvent(GRGEN_MODEL.@EndEvent oldElem) : base(GRGEN_MODEL.NodeType_EndEvent.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
			EventDefinitionName\u0303 = oldElem.EventDefinitionName\u0303;
			ErrorCode\u0303 = oldElem.ErrorCode\u0303;
			Trigger\u0303 = oldElem.Trigger\u0303;
			Result\u0303 = oldElem.Result\u0303;
			cancelActivity\u0303 = oldElem.cancelActivity\u0303;
		}
		public static GRGEN_MODEL.@EndEvent CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@EndEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@EndEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of EndEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target EndEvent
				// explicit initializations of FlowElement for target EndEvent
				// explicit initializations of Activity for target EndEvent
				// explicit initializations of Event for target EndEvent
				// explicit initializations of EndEvent for target EndEvent
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@EndEvent CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@EndEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@EndEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of EndEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target EndEvent
				// explicit initializations of FlowElement for target EndEvent
				// explicit initializations of Activity for target EndEvent
				// explicit initializations of Event for target EndEvent
				// explicit initializations of EndEvent for target EndEvent
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}

		private string EventDefinitionName\u0303;
		public string @EventDefinitionName
		{
			get { return EventDefinitionName\u0303; }
			set { EventDefinitionName\u0303 = value; }
		}

		private string ErrorCode\u0303;
		public string @ErrorCode
		{
			get { return ErrorCode\u0303; }
			set { ErrorCode\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Trigger\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Trigger
		{
			get { return Trigger\u0303; }
			set { Trigger\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Result\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Result
		{
			get { return Result\u0303; }
			set { Result\u0303 = value; }
		}

		private bool cancelActivity\u0303;
		public bool @cancelActivity
		{
			get { return cancelActivity\u0303; }
			set { cancelActivity\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
				case "EventDefinitionName": return this.@EventDefinitionName;
				case "ErrorCode": return this.@ErrorCode;
				case "Trigger": return this.@Trigger;
				case "Result": return this.@Result;
				case "cancelActivity": return this.@cancelActivity;
			}
			throw new NullReferenceException(
				"The node type \"EndEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
				case "EventDefinitionName": this.@EventDefinitionName = (string) value; return;
				case "ErrorCode": this.@ErrorCode = (string) value; return;
				case "Trigger": this.@Trigger = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "Result": this.@Result = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "cancelActivity": this.@cancelActivity = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"EndEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of EndEvent
			this.@Name = null;
			this.@_nOut = 0;
			this.@EventDefinitionName = null;
			this.@ErrorCode = null;
			this.@Trigger = 0;
			this.@Result = 0;
			this.@cancelActivity = false;
			// explicit initializations of BaseElement for target EndEvent
			// explicit initializations of FlowElement for target EndEvent
			// explicit initializations of Activity for target EndEvent
			// explicit initializations of Event for target EndEvent
			// explicit initializations of EndEvent for target EndEvent
		}
	}

	public sealed class NodeType_EndEvent : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_EndEvent typeVar = new GRGEN_MODEL.NodeType_EndEvent();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_EndEvent() : base((int) NodeTypes.@EndEvent)
		{
		}
		public override string Name { get { return "EndEvent"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IEndEvent"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@EndEvent"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@EndEvent();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 7; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				case "EventDefinitionName" : return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				case "ErrorCode" : return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				case "Trigger" : return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				case "Result" : return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				case "cancelActivity" : return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@EndEvent newNode = new GRGEN_MODEL.@EndEvent();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
					// copy attributes for: Event
					{
						GRGEN_MODEL.IEvent old = (GRGEN_MODEL.IEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
				case (int) NodeTypes.@EndEvent:
					// copy attributes for: EndEvent
					{
						GRGEN_MODEL.IEndEvent old = (GRGEN_MODEL.IEndEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node IntermediateEvent ***

	public interface IIntermediateEvent : IEvent
	{
	}

	public sealed class @IntermediateEvent : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IIntermediateEvent
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@IntermediateEvent[] pool = new GRGEN_MODEL.@IntermediateEvent[10];
		
		// explicit initializations of BaseElement for target IntermediateEvent
		// implicit initializations of BaseElement for target IntermediateEvent
		// explicit initializations of FlowElement for target IntermediateEvent
		// implicit initializations of FlowElement for target IntermediateEvent
		// explicit initializations of Activity for target IntermediateEvent
		// implicit initializations of Activity for target IntermediateEvent
		// explicit initializations of Event for target IntermediateEvent
		// implicit initializations of Event for target IntermediateEvent
		// explicit initializations of IntermediateEvent for target IntermediateEvent
		// implicit initializations of IntermediateEvent for target IntermediateEvent
		static @IntermediateEvent() {
		}
		
		public @IntermediateEvent() : base(GRGEN_MODEL.NodeType_IntermediateEvent.typeVar)
		{
			// implicit initialization, map/set creation of IntermediateEvent
			// explicit initializations of BaseElement for target IntermediateEvent
			// explicit initializations of FlowElement for target IntermediateEvent
			// explicit initializations of Activity for target IntermediateEvent
			// explicit initializations of Event for target IntermediateEvent
			// explicit initializations of IntermediateEvent for target IntermediateEvent
		}

		public static GRGEN_MODEL.NodeType_IntermediateEvent TypeInstance { get { return GRGEN_MODEL.NodeType_IntermediateEvent.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@IntermediateEvent(this); }

		private @IntermediateEvent(GRGEN_MODEL.@IntermediateEvent oldElem) : base(GRGEN_MODEL.NodeType_IntermediateEvent.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
			EventDefinitionName\u0303 = oldElem.EventDefinitionName\u0303;
			ErrorCode\u0303 = oldElem.ErrorCode\u0303;
			Trigger\u0303 = oldElem.Trigger\u0303;
			Result\u0303 = oldElem.Result\u0303;
			cancelActivity\u0303 = oldElem.cancelActivity\u0303;
		}
		public static GRGEN_MODEL.@IntermediateEvent CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@IntermediateEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@IntermediateEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of IntermediateEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target IntermediateEvent
				// explicit initializations of FlowElement for target IntermediateEvent
				// explicit initializations of Activity for target IntermediateEvent
				// explicit initializations of Event for target IntermediateEvent
				// explicit initializations of IntermediateEvent for target IntermediateEvent
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@IntermediateEvent CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@IntermediateEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@IntermediateEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of IntermediateEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target IntermediateEvent
				// explicit initializations of FlowElement for target IntermediateEvent
				// explicit initializations of Activity for target IntermediateEvent
				// explicit initializations of Event for target IntermediateEvent
				// explicit initializations of IntermediateEvent for target IntermediateEvent
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}

		private string EventDefinitionName\u0303;
		public string @EventDefinitionName
		{
			get { return EventDefinitionName\u0303; }
			set { EventDefinitionName\u0303 = value; }
		}

		private string ErrorCode\u0303;
		public string @ErrorCode
		{
			get { return ErrorCode\u0303; }
			set { ErrorCode\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Trigger\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Trigger
		{
			get { return Trigger\u0303; }
			set { Trigger\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Result\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Result
		{
			get { return Result\u0303; }
			set { Result\u0303 = value; }
		}

		private bool cancelActivity\u0303;
		public bool @cancelActivity
		{
			get { return cancelActivity\u0303; }
			set { cancelActivity\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
				case "EventDefinitionName": return this.@EventDefinitionName;
				case "ErrorCode": return this.@ErrorCode;
				case "Trigger": return this.@Trigger;
				case "Result": return this.@Result;
				case "cancelActivity": return this.@cancelActivity;
			}
			throw new NullReferenceException(
				"The node type \"IntermediateEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
				case "EventDefinitionName": this.@EventDefinitionName = (string) value; return;
				case "ErrorCode": this.@ErrorCode = (string) value; return;
				case "Trigger": this.@Trigger = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "Result": this.@Result = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "cancelActivity": this.@cancelActivity = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"IntermediateEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of IntermediateEvent
			this.@Name = null;
			this.@_nOut = 0;
			this.@EventDefinitionName = null;
			this.@ErrorCode = null;
			this.@Trigger = 0;
			this.@Result = 0;
			this.@cancelActivity = false;
			// explicit initializations of BaseElement for target IntermediateEvent
			// explicit initializations of FlowElement for target IntermediateEvent
			// explicit initializations of Activity for target IntermediateEvent
			// explicit initializations of Event for target IntermediateEvent
			// explicit initializations of IntermediateEvent for target IntermediateEvent
		}
	}

	public sealed class NodeType_IntermediateEvent : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_IntermediateEvent typeVar = new GRGEN_MODEL.NodeType_IntermediateEvent();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_IntermediateEvent() : base((int) NodeTypes.@IntermediateEvent)
		{
		}
		public override string Name { get { return "IntermediateEvent"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IIntermediateEvent"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@IntermediateEvent"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@IntermediateEvent();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 7; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				case "EventDefinitionName" : return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				case "ErrorCode" : return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				case "Trigger" : return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				case "Result" : return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				case "cancelActivity" : return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@IntermediateEvent newNode = new GRGEN_MODEL.@IntermediateEvent();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@EndEvent:
					// copy attributes for: Event
					{
						GRGEN_MODEL.IEvent old = (GRGEN_MODEL.IEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
					// copy attributes for: IntermediateEvent
					{
						GRGEN_MODEL.IIntermediateEvent old = (GRGEN_MODEL.IIntermediateEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node IntermediateCatchEvent ***

	public interface IIntermediateCatchEvent : IIntermediateEvent
	{
	}

	public sealed class @IntermediateCatchEvent : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IIntermediateCatchEvent
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@IntermediateCatchEvent[] pool = new GRGEN_MODEL.@IntermediateCatchEvent[10];
		
		// explicit initializations of BaseElement for target IntermediateCatchEvent
		// implicit initializations of BaseElement for target IntermediateCatchEvent
		// explicit initializations of FlowElement for target IntermediateCatchEvent
		// implicit initializations of FlowElement for target IntermediateCatchEvent
		// explicit initializations of Activity for target IntermediateCatchEvent
		// implicit initializations of Activity for target IntermediateCatchEvent
		// explicit initializations of Event for target IntermediateCatchEvent
		// implicit initializations of Event for target IntermediateCatchEvent
		// explicit initializations of IntermediateEvent for target IntermediateCatchEvent
		// implicit initializations of IntermediateEvent for target IntermediateCatchEvent
		// explicit initializations of IntermediateCatchEvent for target IntermediateCatchEvent
		// implicit initializations of IntermediateCatchEvent for target IntermediateCatchEvent
		static @IntermediateCatchEvent() {
		}
		
		public @IntermediateCatchEvent() : base(GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar)
		{
			// implicit initialization, map/set creation of IntermediateCatchEvent
			// explicit initializations of BaseElement for target IntermediateCatchEvent
			// explicit initializations of FlowElement for target IntermediateCatchEvent
			// explicit initializations of Activity for target IntermediateCatchEvent
			// explicit initializations of Event for target IntermediateCatchEvent
			// explicit initializations of IntermediateEvent for target IntermediateCatchEvent
			// explicit initializations of IntermediateCatchEvent for target IntermediateCatchEvent
		}

		public static GRGEN_MODEL.NodeType_IntermediateCatchEvent TypeInstance { get { return GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@IntermediateCatchEvent(this); }

		private @IntermediateCatchEvent(GRGEN_MODEL.@IntermediateCatchEvent oldElem) : base(GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
			EventDefinitionName\u0303 = oldElem.EventDefinitionName\u0303;
			ErrorCode\u0303 = oldElem.ErrorCode\u0303;
			Trigger\u0303 = oldElem.Trigger\u0303;
			Result\u0303 = oldElem.Result\u0303;
			cancelActivity\u0303 = oldElem.cancelActivity\u0303;
		}
		public static GRGEN_MODEL.@IntermediateCatchEvent CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@IntermediateCatchEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@IntermediateCatchEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of IntermediateCatchEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target IntermediateCatchEvent
				// explicit initializations of FlowElement for target IntermediateCatchEvent
				// explicit initializations of Activity for target IntermediateCatchEvent
				// explicit initializations of Event for target IntermediateCatchEvent
				// explicit initializations of IntermediateEvent for target IntermediateCatchEvent
				// explicit initializations of IntermediateCatchEvent for target IntermediateCatchEvent
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@IntermediateCatchEvent CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@IntermediateCatchEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@IntermediateCatchEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of IntermediateCatchEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target IntermediateCatchEvent
				// explicit initializations of FlowElement for target IntermediateCatchEvent
				// explicit initializations of Activity for target IntermediateCatchEvent
				// explicit initializations of Event for target IntermediateCatchEvent
				// explicit initializations of IntermediateEvent for target IntermediateCatchEvent
				// explicit initializations of IntermediateCatchEvent for target IntermediateCatchEvent
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}

		private string EventDefinitionName\u0303;
		public string @EventDefinitionName
		{
			get { return EventDefinitionName\u0303; }
			set { EventDefinitionName\u0303 = value; }
		}

		private string ErrorCode\u0303;
		public string @ErrorCode
		{
			get { return ErrorCode\u0303; }
			set { ErrorCode\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Trigger\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Trigger
		{
			get { return Trigger\u0303; }
			set { Trigger\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Result\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Result
		{
			get { return Result\u0303; }
			set { Result\u0303 = value; }
		}

		private bool cancelActivity\u0303;
		public bool @cancelActivity
		{
			get { return cancelActivity\u0303; }
			set { cancelActivity\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
				case "EventDefinitionName": return this.@EventDefinitionName;
				case "ErrorCode": return this.@ErrorCode;
				case "Trigger": return this.@Trigger;
				case "Result": return this.@Result;
				case "cancelActivity": return this.@cancelActivity;
			}
			throw new NullReferenceException(
				"The node type \"IntermediateCatchEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
				case "EventDefinitionName": this.@EventDefinitionName = (string) value; return;
				case "ErrorCode": this.@ErrorCode = (string) value; return;
				case "Trigger": this.@Trigger = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "Result": this.@Result = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "cancelActivity": this.@cancelActivity = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"IntermediateCatchEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of IntermediateCatchEvent
			this.@Name = null;
			this.@_nOut = 0;
			this.@EventDefinitionName = null;
			this.@ErrorCode = null;
			this.@Trigger = 0;
			this.@Result = 0;
			this.@cancelActivity = false;
			// explicit initializations of BaseElement for target IntermediateCatchEvent
			// explicit initializations of FlowElement for target IntermediateCatchEvent
			// explicit initializations of Activity for target IntermediateCatchEvent
			// explicit initializations of Event for target IntermediateCatchEvent
			// explicit initializations of IntermediateEvent for target IntermediateCatchEvent
			// explicit initializations of IntermediateCatchEvent for target IntermediateCatchEvent
		}
	}

	public sealed class NodeType_IntermediateCatchEvent : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_IntermediateCatchEvent typeVar = new GRGEN_MODEL.NodeType_IntermediateCatchEvent();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_IntermediateCatchEvent() : base((int) NodeTypes.@IntermediateCatchEvent)
		{
		}
		public override string Name { get { return "IntermediateCatchEvent"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IIntermediateCatchEvent"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@IntermediateCatchEvent"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@IntermediateCatchEvent();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 7; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				case "EventDefinitionName" : return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				case "ErrorCode" : return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				case "Trigger" : return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				case "Result" : return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				case "cancelActivity" : return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@IntermediateCatchEvent newNode = new GRGEN_MODEL.@IntermediateCatchEvent();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@EndEvent:
					// copy attributes for: Event
					{
						GRGEN_MODEL.IEvent old = (GRGEN_MODEL.IEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
					// copy attributes for: IntermediateEvent
					{
						GRGEN_MODEL.IIntermediateEvent old = (GRGEN_MODEL.IIntermediateEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
				case (int) NodeTypes.@IntermediateCatchEvent:
					// copy attributes for: IntermediateCatchEvent
					{
						GRGEN_MODEL.IIntermediateCatchEvent old = (GRGEN_MODEL.IIntermediateCatchEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node IntermediateThrowEvent ***

	public interface IIntermediateThrowEvent : IIntermediateEvent
	{
	}

	public sealed class @IntermediateThrowEvent : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IIntermediateThrowEvent
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@IntermediateThrowEvent[] pool = new GRGEN_MODEL.@IntermediateThrowEvent[10];
		
		// explicit initializations of BaseElement for target IntermediateThrowEvent
		// implicit initializations of BaseElement for target IntermediateThrowEvent
		// explicit initializations of FlowElement for target IntermediateThrowEvent
		// implicit initializations of FlowElement for target IntermediateThrowEvent
		// explicit initializations of Activity for target IntermediateThrowEvent
		// implicit initializations of Activity for target IntermediateThrowEvent
		// explicit initializations of Event for target IntermediateThrowEvent
		// implicit initializations of Event for target IntermediateThrowEvent
		// explicit initializations of IntermediateEvent for target IntermediateThrowEvent
		// implicit initializations of IntermediateEvent for target IntermediateThrowEvent
		// explicit initializations of IntermediateThrowEvent for target IntermediateThrowEvent
		// implicit initializations of IntermediateThrowEvent for target IntermediateThrowEvent
		static @IntermediateThrowEvent() {
		}
		
		public @IntermediateThrowEvent() : base(GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar)
		{
			// implicit initialization, map/set creation of IntermediateThrowEvent
			// explicit initializations of BaseElement for target IntermediateThrowEvent
			// explicit initializations of FlowElement for target IntermediateThrowEvent
			// explicit initializations of Activity for target IntermediateThrowEvent
			// explicit initializations of Event for target IntermediateThrowEvent
			// explicit initializations of IntermediateEvent for target IntermediateThrowEvent
			// explicit initializations of IntermediateThrowEvent for target IntermediateThrowEvent
		}

		public static GRGEN_MODEL.NodeType_IntermediateThrowEvent TypeInstance { get { return GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@IntermediateThrowEvent(this); }

		private @IntermediateThrowEvent(GRGEN_MODEL.@IntermediateThrowEvent oldElem) : base(GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
			EventDefinitionName\u0303 = oldElem.EventDefinitionName\u0303;
			ErrorCode\u0303 = oldElem.ErrorCode\u0303;
			Trigger\u0303 = oldElem.Trigger\u0303;
			Result\u0303 = oldElem.Result\u0303;
			cancelActivity\u0303 = oldElem.cancelActivity\u0303;
		}
		public static GRGEN_MODEL.@IntermediateThrowEvent CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@IntermediateThrowEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@IntermediateThrowEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of IntermediateThrowEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target IntermediateThrowEvent
				// explicit initializations of FlowElement for target IntermediateThrowEvent
				// explicit initializations of Activity for target IntermediateThrowEvent
				// explicit initializations of Event for target IntermediateThrowEvent
				// explicit initializations of IntermediateEvent for target IntermediateThrowEvent
				// explicit initializations of IntermediateThrowEvent for target IntermediateThrowEvent
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@IntermediateThrowEvent CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@IntermediateThrowEvent node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@IntermediateThrowEvent();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of IntermediateThrowEvent
				node.@Name = null;
				node.@_nOut = 0;
				node.@EventDefinitionName = null;
				node.@ErrorCode = null;
				node.@Trigger = 0;
				node.@Result = 0;
				node.@cancelActivity = false;
				// explicit initializations of BaseElement for target IntermediateThrowEvent
				// explicit initializations of FlowElement for target IntermediateThrowEvent
				// explicit initializations of Activity for target IntermediateThrowEvent
				// explicit initializations of Event for target IntermediateThrowEvent
				// explicit initializations of IntermediateEvent for target IntermediateThrowEvent
				// explicit initializations of IntermediateThrowEvent for target IntermediateThrowEvent
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}

		private string EventDefinitionName\u0303;
		public string @EventDefinitionName
		{
			get { return EventDefinitionName\u0303; }
			set { EventDefinitionName\u0303 = value; }
		}

		private string ErrorCode\u0303;
		public string @ErrorCode
		{
			get { return ErrorCode\u0303; }
			set { ErrorCode\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Trigger\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Trigger
		{
			get { return Trigger\u0303; }
			set { Trigger\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_TriggerType Result\u0303;
		public GRGEN_MODEL.ENUM_TriggerType @Result
		{
			get { return Result\u0303; }
			set { Result\u0303 = value; }
		}

		private bool cancelActivity\u0303;
		public bool @cancelActivity
		{
			get { return cancelActivity\u0303; }
			set { cancelActivity\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
				case "EventDefinitionName": return this.@EventDefinitionName;
				case "ErrorCode": return this.@ErrorCode;
				case "Trigger": return this.@Trigger;
				case "Result": return this.@Result;
				case "cancelActivity": return this.@cancelActivity;
			}
			throw new NullReferenceException(
				"The node type \"IntermediateThrowEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
				case "EventDefinitionName": this.@EventDefinitionName = (string) value; return;
				case "ErrorCode": this.@ErrorCode = (string) value; return;
				case "Trigger": this.@Trigger = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "Result": this.@Result = (GRGEN_MODEL.ENUM_TriggerType) value; return;
				case "cancelActivity": this.@cancelActivity = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"IntermediateThrowEvent\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of IntermediateThrowEvent
			this.@Name = null;
			this.@_nOut = 0;
			this.@EventDefinitionName = null;
			this.@ErrorCode = null;
			this.@Trigger = 0;
			this.@Result = 0;
			this.@cancelActivity = false;
			// explicit initializations of BaseElement for target IntermediateThrowEvent
			// explicit initializations of FlowElement for target IntermediateThrowEvent
			// explicit initializations of Activity for target IntermediateThrowEvent
			// explicit initializations of Event for target IntermediateThrowEvent
			// explicit initializations of IntermediateEvent for target IntermediateThrowEvent
			// explicit initializations of IntermediateThrowEvent for target IntermediateThrowEvent
		}
	}

	public sealed class NodeType_IntermediateThrowEvent : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_IntermediateThrowEvent typeVar = new GRGEN_MODEL.NodeType_IntermediateThrowEvent();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public NodeType_IntermediateThrowEvent() : base((int) NodeTypes.@IntermediateThrowEvent)
		{
		}
		public override string Name { get { return "IntermediateThrowEvent"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IIntermediateThrowEvent"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@IntermediateThrowEvent"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@IntermediateThrowEvent();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 7; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				yield return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				case "EventDefinitionName" : return GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName;
				case "ErrorCode" : return GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode;
				case "Trigger" : return GRGEN_MODEL.NodeType_Event.AttributeType_Trigger;
				case "Result" : return GRGEN_MODEL.NodeType_Event.AttributeType_Result;
				case "cancelActivity" : return GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@IntermediateThrowEvent newNode = new GRGEN_MODEL.@IntermediateThrowEvent();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@EndEvent:
					// copy attributes for: Event
					{
						GRGEN_MODEL.IEvent old = (GRGEN_MODEL.IEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
					// copy attributes for: IntermediateEvent
					{
						GRGEN_MODEL.IIntermediateEvent old = (GRGEN_MODEL.IIntermediateEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
				case (int) NodeTypes.@IntermediateThrowEvent:
					// copy attributes for: IntermediateThrowEvent
					{
						GRGEN_MODEL.IIntermediateThrowEvent old = (GRGEN_MODEL.IIntermediateThrowEvent) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@EventDefinitionName = old.@EventDefinitionName;
						newNode.@ErrorCode = old.@ErrorCode;
						newNode.@Trigger = old.@Trigger;
						newNode.@Result = old.@Result;
						newNode.@cancelActivity = old.@cancelActivity;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node Gateway ***

	public interface IGateway : IActivity
	{
		GRGEN_MODEL.ENUM_GatewayType @GatewayType { get; set; }
		GRGEN_MODEL.ENUM_ExclusiveType @ExclusiveType { get; set; }
		bool @Instantiate { get; set; }
	}

	public sealed class @Gateway : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IGateway
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Gateway[] pool = new GRGEN_MODEL.@Gateway[10];
		
		// explicit initializations of BaseElement for target Gateway
		// implicit initializations of BaseElement for target Gateway
		// explicit initializations of FlowElement for target Gateway
		// implicit initializations of FlowElement for target Gateway
		// explicit initializations of Activity for target Gateway
		// implicit initializations of Activity for target Gateway
		// explicit initializations of Gateway for target Gateway
		// implicit initializations of Gateway for target Gateway
		static @Gateway() {
		}
		
		public @Gateway() : base(GRGEN_MODEL.NodeType_Gateway.typeVar)
		{
			// implicit initialization, map/set creation of Gateway
			// explicit initializations of BaseElement for target Gateway
			// explicit initializations of FlowElement for target Gateway
			// explicit initializations of Activity for target Gateway
			// explicit initializations of Gateway for target Gateway
		}

		public static GRGEN_MODEL.NodeType_Gateway TypeInstance { get { return GRGEN_MODEL.NodeType_Gateway.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Gateway(this); }

		private @Gateway(GRGEN_MODEL.@Gateway oldElem) : base(GRGEN_MODEL.NodeType_Gateway.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
			_nOut\u0303 = oldElem._nOut\u0303;
			GatewayType\u0303 = oldElem.GatewayType\u0303;
			ExclusiveType\u0303 = oldElem.ExclusiveType\u0303;
			Instantiate\u0303 = oldElem.Instantiate\u0303;
		}
		public static GRGEN_MODEL.@Gateway CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Gateway node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Gateway();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Gateway
				node.@Name = null;
				node.@_nOut = 0;
				node.@GatewayType = 0;
				node.@ExclusiveType = 0;
				node.@Instantiate = false;
				// explicit initializations of BaseElement for target Gateway
				// explicit initializations of FlowElement for target Gateway
				// explicit initializations of Activity for target Gateway
				// explicit initializations of Gateway for target Gateway
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Gateway CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@Gateway node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Gateway();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Gateway
				node.@Name = null;
				node.@_nOut = 0;
				node.@GatewayType = 0;
				node.@ExclusiveType = 0;
				node.@Instantiate = false;
				// explicit initializations of BaseElement for target Gateway
				// explicit initializations of FlowElement for target Gateway
				// explicit initializations of Activity for target Gateway
				// explicit initializations of Gateway for target Gateway
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}

		private int _nOut\u0303;
		public int @_nOut
		{
			get { return _nOut\u0303; }
			set { _nOut\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_GatewayType GatewayType\u0303;
		public GRGEN_MODEL.ENUM_GatewayType @GatewayType
		{
			get { return GatewayType\u0303; }
			set { GatewayType\u0303 = value; }
		}

		private GRGEN_MODEL.ENUM_ExclusiveType ExclusiveType\u0303;
		public GRGEN_MODEL.ENUM_ExclusiveType @ExclusiveType
		{
			get { return ExclusiveType\u0303; }
			set { ExclusiveType\u0303 = value; }
		}

		private bool Instantiate\u0303;
		public bool @Instantiate
		{
			get { return Instantiate\u0303; }
			set { Instantiate\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
				case "_nOut": return this.@_nOut;
				case "GatewayType": return this.@GatewayType;
				case "ExclusiveType": return this.@ExclusiveType;
				case "Instantiate": return this.@Instantiate;
			}
			throw new NullReferenceException(
				"The node type \"Gateway\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
				case "_nOut": this.@_nOut = (int) value; return;
				case "GatewayType": this.@GatewayType = (GRGEN_MODEL.ENUM_GatewayType) value; return;
				case "ExclusiveType": this.@ExclusiveType = (GRGEN_MODEL.ENUM_ExclusiveType) value; return;
				case "Instantiate": this.@Instantiate = (bool) value; return;
			}
			throw new NullReferenceException(
				"The node type \"Gateway\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Gateway
			this.@Name = null;
			this.@_nOut = 0;
			this.@GatewayType = 0;
			this.@ExclusiveType = 0;
			this.@Instantiate = false;
			// explicit initializations of BaseElement for target Gateway
			// explicit initializations of FlowElement for target Gateway
			// explicit initializations of Activity for target Gateway
			// explicit initializations of Gateway for target Gateway
		}
	}

	public sealed class NodeType_Gateway : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Gateway typeVar = new GRGEN_MODEL.NodeType_Gateway();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_GatewayType;
		public static GRGEN_LIBGR.AttributeType AttributeType_ExclusiveType;
		public static GRGEN_LIBGR.AttributeType AttributeType_Instantiate;
		public NodeType_Gateway() : base((int) NodeTypes.@Gateway)
		{
			AttributeType_GatewayType = new GRGEN_LIBGR.AttributeType("GatewayType", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@GatewayType, null, null, null);
			AttributeType_ExclusiveType = new GRGEN_LIBGR.AttributeType("ExclusiveType", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@ExclusiveType, null, null, null);
			AttributeType_Instantiate = new GRGEN_LIBGR.AttributeType("Instantiate", this, GRGEN_LIBGR.AttributeKind.BooleanAttr, null, null, null, null);
		}
		public override string Name { get { return "Gateway"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IGateway"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Gateway"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Gateway();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 5; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				yield return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				yield return AttributeType_GatewayType;
				yield return AttributeType_ExclusiveType;
				yield return AttributeType_Instantiate;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return GRGEN_MODEL.NodeType_Activity.AttributeType_Name;
				case "_nOut" : return GRGEN_MODEL.NodeType_Activity.AttributeType__nOut;
				case "GatewayType" : return AttributeType_GatewayType;
				case "ExclusiveType" : return AttributeType_ExclusiveType;
				case "Instantiate" : return AttributeType_Instantiate;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@Gateway newNode = new GRGEN_MODEL.@Gateway();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@Activity:
				case (int) NodeTypes.@Task:
				case (int) NodeTypes.@Event:
				case (int) NodeTypes.@BlockActivity:
				case (int) NodeTypes.@StartEvent:
				case (int) NodeTypes.@EndEvent:
				case (int) NodeTypes.@IntermediateEvent:
				case (int) NodeTypes.@IntermediateCatchEvent:
				case (int) NodeTypes.@IntermediateThrowEvent:
					// copy attributes for: Activity
					{
						GRGEN_MODEL.IActivity old = (GRGEN_MODEL.IActivity) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
					}
					break;
				case (int) NodeTypes.@Gateway:
					// copy attributes for: Gateway
					{
						GRGEN_MODEL.IGateway old = (GRGEN_MODEL.IGateway) oldNode;
						newNode.@Name = old.@Name;
						newNode.@_nOut = old.@_nOut;
						newNode.@GatewayType = old.@GatewayType;
						newNode.@ExclusiveType = old.@ExclusiveType;
						newNode.@Instantiate = old.@Instantiate;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node _Flow ***

	public interface I_Flow : IFlowElement
	{
	}

	public sealed class NodeType__Flow : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType__Flow typeVar = new GRGEN_MODEL.NodeType__Flow();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, true, false, false, false, false, false, false, };
		public NodeType__Flow() : base((int) NodeTypes.@_Flow)
		{
		}
		public override string Name { get { return "_Flow"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_Flow"; } }
		public override string NodeClassName { get { return null; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			throw new Exception("The abstract node type _Flow cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			throw new Exception("Cannot retype to the abstract type _Flow!");
		}
	}

	// *** Node _SequenceFlow ***

	public interface I_SequenceFlow : I_Flow
	{
		GRGEN_MODEL.ENUM_ConditionType @Type { get; set; }
	}

	public sealed class @_SequenceFlow : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.I_SequenceFlow
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@_SequenceFlow[] pool = new GRGEN_MODEL.@_SequenceFlow[10];
		
		// explicit initializations of BaseElement for target _SequenceFlow
		// implicit initializations of BaseElement for target _SequenceFlow
		// explicit initializations of FlowElement for target _SequenceFlow
		// implicit initializations of FlowElement for target _SequenceFlow
		// explicit initializations of _Flow for target _SequenceFlow
		// implicit initializations of _Flow for target _SequenceFlow
		// explicit initializations of _SequenceFlow for target _SequenceFlow
		// implicit initializations of _SequenceFlow for target _SequenceFlow
		static @_SequenceFlow() {
		}
		
		public @_SequenceFlow() : base(GRGEN_MODEL.NodeType__SequenceFlow.typeVar)
		{
			// implicit initialization, map/set creation of _SequenceFlow
			// explicit initializations of BaseElement for target _SequenceFlow
			// explicit initializations of FlowElement for target _SequenceFlow
			// explicit initializations of _Flow for target _SequenceFlow
			// explicit initializations of _SequenceFlow for target _SequenceFlow
		}

		public static GRGEN_MODEL.NodeType__SequenceFlow TypeInstance { get { return GRGEN_MODEL.NodeType__SequenceFlow.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@_SequenceFlow(this); }

		private @_SequenceFlow(GRGEN_MODEL.@_SequenceFlow oldElem) : base(GRGEN_MODEL.NodeType__SequenceFlow.typeVar)
		{
			Type\u0303 = oldElem.Type\u0303;
		}
		public static GRGEN_MODEL.@_SequenceFlow CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@_SequenceFlow node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@_SequenceFlow();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of _SequenceFlow
				node.@Type = 0;
				// explicit initializations of BaseElement for target _SequenceFlow
				// explicit initializations of FlowElement for target _SequenceFlow
				// explicit initializations of _Flow for target _SequenceFlow
				// explicit initializations of _SequenceFlow for target _SequenceFlow
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@_SequenceFlow CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@_SequenceFlow node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@_SequenceFlow();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of _SequenceFlow
				node.@Type = 0;
				// explicit initializations of BaseElement for target _SequenceFlow
				// explicit initializations of FlowElement for target _SequenceFlow
				// explicit initializations of _Flow for target _SequenceFlow
				// explicit initializations of _SequenceFlow for target _SequenceFlow
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private GRGEN_MODEL.ENUM_ConditionType Type\u0303;
		public GRGEN_MODEL.ENUM_ConditionType @Type
		{
			get { return Type\u0303; }
			set { Type\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Type": return this.@Type;
			}
			throw new NullReferenceException(
				"The node type \"_SequenceFlow\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Type": this.@Type = (GRGEN_MODEL.ENUM_ConditionType) value; return;
			}
			throw new NullReferenceException(
				"The node type \"_SequenceFlow\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of _SequenceFlow
			this.@Type = 0;
			// explicit initializations of BaseElement for target _SequenceFlow
			// explicit initializations of FlowElement for target _SequenceFlow
			// explicit initializations of _Flow for target _SequenceFlow
			// explicit initializations of _SequenceFlow for target _SequenceFlow
		}
	}

	public sealed class NodeType__SequenceFlow : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType__SequenceFlow typeVar = new GRGEN_MODEL.NodeType__SequenceFlow();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_Type;
		public NodeType__SequenceFlow() : base((int) NodeTypes.@_SequenceFlow)
		{
			AttributeType_Type = new GRGEN_LIBGR.AttributeType("Type", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@ConditionType, null, null, null);
		}
		public override string Name { get { return "_SequenceFlow"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_SequenceFlow"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@_SequenceFlow"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@_SequenceFlow();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_Type;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Type" : return AttributeType_Type;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@_SequenceFlow newNode = new GRGEN_MODEL.@_SequenceFlow();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@_SequenceFlow:
					// copy attributes for: _SequenceFlow
					{
						GRGEN_MODEL.I_SequenceFlow old = (GRGEN_MODEL.I_SequenceFlow) oldNode;
						newNode.@Type = old.@Type;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node _MessageFlow ***

	public interface I_MessageFlow : I_Flow
	{
	}

	public sealed class @_MessageFlow : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.I_MessageFlow
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@_MessageFlow[] pool = new GRGEN_MODEL.@_MessageFlow[10];
		
		// explicit initializations of BaseElement for target _MessageFlow
		// implicit initializations of BaseElement for target _MessageFlow
		// explicit initializations of FlowElement for target _MessageFlow
		// implicit initializations of FlowElement for target _MessageFlow
		// explicit initializations of _Flow for target _MessageFlow
		// implicit initializations of _Flow for target _MessageFlow
		// explicit initializations of _MessageFlow for target _MessageFlow
		// implicit initializations of _MessageFlow for target _MessageFlow
		static @_MessageFlow() {
		}
		
		public @_MessageFlow() : base(GRGEN_MODEL.NodeType__MessageFlow.typeVar)
		{
			// implicit initialization, map/set creation of _MessageFlow
			// explicit initializations of BaseElement for target _MessageFlow
			// explicit initializations of FlowElement for target _MessageFlow
			// explicit initializations of _Flow for target _MessageFlow
			// explicit initializations of _MessageFlow for target _MessageFlow
		}

		public static GRGEN_MODEL.NodeType__MessageFlow TypeInstance { get { return GRGEN_MODEL.NodeType__MessageFlow.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@_MessageFlow(this); }

		private @_MessageFlow(GRGEN_MODEL.@_MessageFlow oldElem) : base(GRGEN_MODEL.NodeType__MessageFlow.typeVar)
		{
		}
		public static GRGEN_MODEL.@_MessageFlow CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@_MessageFlow node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@_MessageFlow();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of _MessageFlow
				// explicit initializations of BaseElement for target _MessageFlow
				// explicit initializations of FlowElement for target _MessageFlow
				// explicit initializations of _Flow for target _MessageFlow
				// explicit initializations of _MessageFlow for target _MessageFlow
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@_MessageFlow CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@_MessageFlow node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@_MessageFlow();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of _MessageFlow
				// explicit initializations of BaseElement for target _MessageFlow
				// explicit initializations of FlowElement for target _MessageFlow
				// explicit initializations of _Flow for target _MessageFlow
				// explicit initializations of _MessageFlow for target _MessageFlow
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"_MessageFlow\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"_MessageFlow\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of _MessageFlow
			// explicit initializations of BaseElement for target _MessageFlow
			// explicit initializations of FlowElement for target _MessageFlow
			// explicit initializations of _Flow for target _MessageFlow
			// explicit initializations of _MessageFlow for target _MessageFlow
		}
	}

	public sealed class NodeType__MessageFlow : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType__MessageFlow typeVar = new GRGEN_MODEL.NodeType__MessageFlow();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public NodeType__MessageFlow() : base((int) NodeTypes.@_MessageFlow)
		{
		}
		public override string Name { get { return "_MessageFlow"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_MessageFlow"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@_MessageFlow"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@_MessageFlow();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@_MessageFlow();
		}

	}

	// *** Node dMarker ***

	public interface IdMarker : GRGEN_LIBGR.INode
	{
	}

	public sealed class @dMarker : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IdMarker
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@dMarker[] pool = new GRGEN_MODEL.@dMarker[10];
		
		// explicit initializations of dMarker for target dMarker
		// implicit initializations of dMarker for target dMarker
		static @dMarker() {
		}
		
		public @dMarker() : base(GRGEN_MODEL.NodeType_dMarker.typeVar)
		{
			// implicit initialization, map/set creation of dMarker
			// explicit initializations of dMarker for target dMarker
		}

		public static GRGEN_MODEL.NodeType_dMarker TypeInstance { get { return GRGEN_MODEL.NodeType_dMarker.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@dMarker(this); }

		private @dMarker(GRGEN_MODEL.@dMarker oldElem) : base(GRGEN_MODEL.NodeType_dMarker.typeVar)
		{
		}
		public static GRGEN_MODEL.@dMarker CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@dMarker node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@dMarker();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of dMarker
				// explicit initializations of dMarker for target dMarker
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@dMarker CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@dMarker node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@dMarker();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of dMarker
				// explicit initializations of dMarker for target dMarker
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"dMarker\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"dMarker\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of dMarker
			// explicit initializations of dMarker for target dMarker
		}
	}

	public sealed class NodeType_dMarker : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_dMarker typeVar = new GRGEN_MODEL.NodeType_dMarker();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public NodeType_dMarker() : base((int) NodeTypes.@dMarker)
		{
		}
		public override string Name { get { return "dMarker"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IdMarker"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@dMarker"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@dMarker();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@dMarker();
		}

	}

	// *** Node _Association ***

	public interface I_Association : I_Flow
	{
		string @Name { get; set; }
	}

	public sealed class @_Association : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.I_Association
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@_Association[] pool = new GRGEN_MODEL.@_Association[10];
		
		// explicit initializations of BaseElement for target _Association
		// implicit initializations of BaseElement for target _Association
		// explicit initializations of FlowElement for target _Association
		// implicit initializations of FlowElement for target _Association
		// explicit initializations of _Flow for target _Association
		// implicit initializations of _Flow for target _Association
		// explicit initializations of _Association for target _Association
		// implicit initializations of _Association for target _Association
		static @_Association() {
		}
		
		public @_Association() : base(GRGEN_MODEL.NodeType__Association.typeVar)
		{
			// implicit initialization, map/set creation of _Association
			// explicit initializations of BaseElement for target _Association
			// explicit initializations of FlowElement for target _Association
			// explicit initializations of _Flow for target _Association
			// explicit initializations of _Association for target _Association
		}

		public static GRGEN_MODEL.NodeType__Association TypeInstance { get { return GRGEN_MODEL.NodeType__Association.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@_Association(this); }

		private @_Association(GRGEN_MODEL.@_Association oldElem) : base(GRGEN_MODEL.NodeType__Association.typeVar)
		{
			Name\u0303 = oldElem.Name\u0303;
		}
		public static GRGEN_MODEL.@_Association CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@_Association node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@_Association();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of _Association
				node.@Name = null;
				// explicit initializations of BaseElement for target _Association
				// explicit initializations of FlowElement for target _Association
				// explicit initializations of _Flow for target _Association
				// explicit initializations of _Association for target _Association
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@_Association CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@_Association node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@_Association();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of _Association
				node.@Name = null;
				// explicit initializations of BaseElement for target _Association
				// explicit initializations of FlowElement for target _Association
				// explicit initializations of _Flow for target _Association
				// explicit initializations of _Association for target _Association
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string Name\u0303;
		public string @Name
		{
			get { return Name\u0303; }
			set { Name\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Name": return this.@Name;
			}
			throw new NullReferenceException(
				"The node type \"_Association\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Name": this.@Name = (string) value; return;
			}
			throw new NullReferenceException(
				"The node type \"_Association\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of _Association
			this.@Name = null;
			// explicit initializations of BaseElement for target _Association
			// explicit initializations of FlowElement for target _Association
			// explicit initializations of _Flow for target _Association
			// explicit initializations of _Association for target _Association
		}
	}

	public sealed class NodeType__Association : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType__Association typeVar = new GRGEN_MODEL.NodeType__Association();
		public static bool[] isA = new bool[] { true, false, false, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, true, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_Name;
		public NodeType__Association() : base((int) NodeTypes.@_Association)
		{
			AttributeType_Name = new GRGEN_LIBGR.AttributeType("Name", this, GRGEN_LIBGR.AttributeKind.StringAttr, null, null, null, null);
		}
		public override string Name { get { return "_Association"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_Association"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@_Association"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@_Association();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_Name;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Name" : return AttributeType_Name;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@_Association newNode = new GRGEN_MODEL.@_Association();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@_Association:
					// copy attributes for: _Association
					{
						GRGEN_MODEL.I_Association old = (GRGEN_MODEL.I_Association) oldNode;
						newNode.@Name = old.@Name;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node Marking ***

	public interface IMarking : GRGEN_LIBGR.INode
	{
	}

	public sealed class @Marking : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IMarking
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Marking[] pool = new GRGEN_MODEL.@Marking[10];
		
		// explicit initializations of Marking for target Marking
		// implicit initializations of Marking for target Marking
		static @Marking() {
		}
		
		public @Marking() : base(GRGEN_MODEL.NodeType_Marking.typeVar)
		{
			// implicit initialization, map/set creation of Marking
			// explicit initializations of Marking for target Marking
		}

		public static GRGEN_MODEL.NodeType_Marking TypeInstance { get { return GRGEN_MODEL.NodeType_Marking.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@Marking(this); }

		private @Marking(GRGEN_MODEL.@Marking oldElem) : base(GRGEN_MODEL.NodeType_Marking.typeVar)
		{
		}
		public static GRGEN_MODEL.@Marking CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@Marking node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Marking();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Marking
				// explicit initializations of Marking for target Marking
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@Marking CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@Marking node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@Marking();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of Marking
				// explicit initializations of Marking for target Marking
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"Marking\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"Marking\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Marking
			// explicit initializations of Marking for target Marking
		}
	}

	public sealed class NodeType_Marking : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_Marking typeVar = new GRGEN_MODEL.NodeType_Marking();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, true, false, false, false, };
		public NodeType_Marking() : base((int) NodeTypes.@Marking)
		{
		}
		public override string Name { get { return "Marking"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IMarking"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Marking"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@Marking();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@Marking();
		}

	}

	// *** Node HighlightMarking ***

	public interface IHighlightMarking : IMarking
	{
	}

	public sealed class @HighlightMarking : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IHighlightMarking
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@HighlightMarking[] pool = new GRGEN_MODEL.@HighlightMarking[10];
		
		// explicit initializations of Marking for target HighlightMarking
		// implicit initializations of Marking for target HighlightMarking
		// explicit initializations of HighlightMarking for target HighlightMarking
		// implicit initializations of HighlightMarking for target HighlightMarking
		static @HighlightMarking() {
		}
		
		public @HighlightMarking() : base(GRGEN_MODEL.NodeType_HighlightMarking.typeVar)
		{
			// implicit initialization, map/set creation of HighlightMarking
			// explicit initializations of Marking for target HighlightMarking
			// explicit initializations of HighlightMarking for target HighlightMarking
		}

		public static GRGEN_MODEL.NodeType_HighlightMarking TypeInstance { get { return GRGEN_MODEL.NodeType_HighlightMarking.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@HighlightMarking(this); }

		private @HighlightMarking(GRGEN_MODEL.@HighlightMarking oldElem) : base(GRGEN_MODEL.NodeType_HighlightMarking.typeVar)
		{
		}
		public static GRGEN_MODEL.@HighlightMarking CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@HighlightMarking node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HighlightMarking();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HighlightMarking
				// explicit initializations of Marking for target HighlightMarking
				// explicit initializations of HighlightMarking for target HighlightMarking
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@HighlightMarking CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@HighlightMarking node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@HighlightMarking();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of HighlightMarking
				// explicit initializations of Marking for target HighlightMarking
				// explicit initializations of HighlightMarking for target HighlightMarking
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"HighlightMarking\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"HighlightMarking\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of HighlightMarking
			// explicit initializations of Marking for target HighlightMarking
			// explicit initializations of HighlightMarking for target HighlightMarking
		}
	}

	public sealed class NodeType_HighlightMarking : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_HighlightMarking typeVar = new GRGEN_MODEL.NodeType_HighlightMarking();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public NodeType_HighlightMarking() : base((int) NodeTypes.@HighlightMarking)
		{
		}
		public override string Name { get { return "HighlightMarking"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IHighlightMarking"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@HighlightMarking"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@HighlightMarking();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@HighlightMarking();
		}

	}

	// *** Node MarkingFromLog ***

	public interface IMarkingFromLog : IMarking
	{
	}

	public sealed class @MarkingFromLog : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IMarkingFromLog
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@MarkingFromLog[] pool = new GRGEN_MODEL.@MarkingFromLog[10];
		
		// explicit initializations of Marking for target MarkingFromLog
		// implicit initializations of Marking for target MarkingFromLog
		// explicit initializations of MarkingFromLog for target MarkingFromLog
		// implicit initializations of MarkingFromLog for target MarkingFromLog
		static @MarkingFromLog() {
		}
		
		public @MarkingFromLog() : base(GRGEN_MODEL.NodeType_MarkingFromLog.typeVar)
		{
			// implicit initialization, map/set creation of MarkingFromLog
			// explicit initializations of Marking for target MarkingFromLog
			// explicit initializations of MarkingFromLog for target MarkingFromLog
		}

		public static GRGEN_MODEL.NodeType_MarkingFromLog TypeInstance { get { return GRGEN_MODEL.NodeType_MarkingFromLog.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@MarkingFromLog(this); }

		private @MarkingFromLog(GRGEN_MODEL.@MarkingFromLog oldElem) : base(GRGEN_MODEL.NodeType_MarkingFromLog.typeVar)
		{
		}
		public static GRGEN_MODEL.@MarkingFromLog CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@MarkingFromLog node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@MarkingFromLog();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of MarkingFromLog
				// explicit initializations of Marking for target MarkingFromLog
				// explicit initializations of MarkingFromLog for target MarkingFromLog
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@MarkingFromLog CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@MarkingFromLog node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@MarkingFromLog();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of MarkingFromLog
				// explicit initializations of Marking for target MarkingFromLog
				// explicit initializations of MarkingFromLog for target MarkingFromLog
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The node type \"MarkingFromLog\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The node type \"MarkingFromLog\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of MarkingFromLog
			// explicit initializations of Marking for target MarkingFromLog
			// explicit initializations of MarkingFromLog for target MarkingFromLog
		}
	}

	public sealed class NodeType_MarkingFromLog : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_MarkingFromLog typeVar = new GRGEN_MODEL.NodeType_MarkingFromLog();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public NodeType_MarkingFromLog() : base((int) NodeTypes.@MarkingFromLog)
		{
		}
		public override string Name { get { return "MarkingFromLog"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IMarkingFromLog"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@MarkingFromLog"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@MarkingFromLog();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			return new GRGEN_MODEL.@MarkingFromLog();
		}

	}

	// *** Node MnextWithCause ***

	public interface IMnextWithCause : GRGEN_LIBGR.INode
	{
		string @ruleName { get; set; }
	}

	public sealed class @MnextWithCause : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IMnextWithCause
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@MnextWithCause[] pool = new GRGEN_MODEL.@MnextWithCause[10];
		
		// explicit initializations of MnextWithCause for target MnextWithCause
		// implicit initializations of MnextWithCause for target MnextWithCause
		static @MnextWithCause() {
		}
		
		public @MnextWithCause() : base(GRGEN_MODEL.NodeType_MnextWithCause.typeVar)
		{
			// implicit initialization, map/set creation of MnextWithCause
			// explicit initializations of MnextWithCause for target MnextWithCause
		}

		public static GRGEN_MODEL.NodeType_MnextWithCause TypeInstance { get { return GRGEN_MODEL.NodeType_MnextWithCause.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@MnextWithCause(this); }

		private @MnextWithCause(GRGEN_MODEL.@MnextWithCause oldElem) : base(GRGEN_MODEL.NodeType_MnextWithCause.typeVar)
		{
			ruleName\u0303 = oldElem.ruleName\u0303;
		}
		public static GRGEN_MODEL.@MnextWithCause CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@MnextWithCause node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@MnextWithCause();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of MnextWithCause
				node.@ruleName = null;
				// explicit initializations of MnextWithCause for target MnextWithCause
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@MnextWithCause CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@MnextWithCause node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@MnextWithCause();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of MnextWithCause
				node.@ruleName = null;
				// explicit initializations of MnextWithCause for target MnextWithCause
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string ruleName\u0303;
		public string @ruleName
		{
			get { return ruleName\u0303; }
			set { ruleName\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "ruleName": return this.@ruleName;
			}
			throw new NullReferenceException(
				"The node type \"MnextWithCause\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "ruleName": this.@ruleName = (string) value; return;
			}
			throw new NullReferenceException(
				"The node type \"MnextWithCause\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of MnextWithCause
			this.@ruleName = null;
			// explicit initializations of MnextWithCause for target MnextWithCause
		}
	}

	public sealed class NodeType_MnextWithCause : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_MnextWithCause typeVar = new GRGEN_MODEL.NodeType_MnextWithCause();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_ruleName;
		public NodeType_MnextWithCause() : base((int) NodeTypes.@MnextWithCause)
		{
			AttributeType_ruleName = new GRGEN_LIBGR.AttributeType("ruleName", this, GRGEN_LIBGR.AttributeKind.StringAttr, null, null, null, null);
		}
		public override string Name { get { return "MnextWithCause"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IMnextWithCause"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@MnextWithCause"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@MnextWithCause();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_ruleName;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "ruleName" : return AttributeType_ruleName;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@MnextWithCause newNode = new GRGEN_MODEL.@MnextWithCause();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@MnextWithCause:
					// copy attributes for: MnextWithCause
					{
						GRGEN_MODEL.IMnextWithCause old = (GRGEN_MODEL.IMnextWithCause) oldNode;
						newNode.@ruleName = old.@ruleName;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node DummyInt ***

	public interface IDummyInt : GRGEN_LIBGR.INode
	{
		int @val { get; set; }
	}

	public sealed class @DummyInt : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.IDummyInt
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@DummyInt[] pool = new GRGEN_MODEL.@DummyInt[10];
		
		// explicit initializations of DummyInt for target DummyInt
		// implicit initializations of DummyInt for target DummyInt
		static @DummyInt() {
		}
		
		public @DummyInt() : base(GRGEN_MODEL.NodeType_DummyInt.typeVar)
		{
			// implicit initialization, map/set creation of DummyInt
			// explicit initializations of DummyInt for target DummyInt
		}

		public static GRGEN_MODEL.NodeType_DummyInt TypeInstance { get { return GRGEN_MODEL.NodeType_DummyInt.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@DummyInt(this); }

		private @DummyInt(GRGEN_MODEL.@DummyInt oldElem) : base(GRGEN_MODEL.NodeType_DummyInt.typeVar)
		{
			val\u0303 = oldElem.val\u0303;
		}
		public static GRGEN_MODEL.@DummyInt CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@DummyInt node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@DummyInt();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of DummyInt
				node.@val = 0;
				// explicit initializations of DummyInt for target DummyInt
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@DummyInt CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@DummyInt node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@DummyInt();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of DummyInt
				node.@val = 0;
				// explicit initializations of DummyInt for target DummyInt
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private int val\u0303;
		public int @val
		{
			get { return val\u0303; }
			set { val\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "val": return this.@val;
			}
			throw new NullReferenceException(
				"The node type \"DummyInt\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "val": this.@val = (int) value; return;
			}
			throw new NullReferenceException(
				"The node type \"DummyInt\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of DummyInt
			this.@val = 0;
			// explicit initializations of DummyInt for target DummyInt
		}
	}

	public sealed class NodeType_DummyInt : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_DummyInt typeVar = new GRGEN_MODEL.NodeType_DummyInt();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_val;
		public NodeType_DummyInt() : base((int) NodeTypes.@DummyInt)
		{
			AttributeType_val = new GRGEN_LIBGR.AttributeType("val", this, GRGEN_LIBGR.AttributeKind.IntegerAttr, null, null, null, null);
		}
		public override string Name { get { return "DummyInt"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IDummyInt"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@DummyInt"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@DummyInt();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_val;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "val" : return AttributeType_val;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@DummyInt newNode = new GRGEN_MODEL.@DummyInt();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@DummyInt:
					// copy attributes for: DummyInt
					{
						GRGEN_MODEL.IDummyInt old = (GRGEN_MODEL.IDummyInt) oldNode;
						newNode.@val = old.@val;
					}
					break;
			}
			return newNode;
		}

	}

	// *** Node SimulatorSettings ***

	public interface ISimulatorSettings : GRGEN_LIBGR.INode
	{
		GRGEN_MODEL.ENUM_SimulatorState @state { get; set; }
	}

	public sealed class @SimulatorSettings : GRGEN_LGSP.LGSPNode, GRGEN_MODEL.ISimulatorSettings
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@SimulatorSettings[] pool = new GRGEN_MODEL.@SimulatorSettings[10];
		
		// explicit initializations of SimulatorSettings for target SimulatorSettings
		// implicit initializations of SimulatorSettings for target SimulatorSettings
		static @SimulatorSettings() {
		}
		
		public @SimulatorSettings() : base(GRGEN_MODEL.NodeType_SimulatorSettings.typeVar)
		{
			// implicit initialization, map/set creation of SimulatorSettings
			// explicit initializations of SimulatorSettings for target SimulatorSettings
		}

		public static GRGEN_MODEL.NodeType_SimulatorSettings TypeInstance { get { return GRGEN_MODEL.NodeType_SimulatorSettings.typeVar; } }

		public override GRGEN_LIBGR.INode Clone() { return new GRGEN_MODEL.@SimulatorSettings(this); }

		private @SimulatorSettings(GRGEN_MODEL.@SimulatorSettings oldElem) : base(GRGEN_MODEL.NodeType_SimulatorSettings.typeVar)
		{
			state\u0303 = oldElem.state\u0303;
		}
		public static GRGEN_MODEL.@SimulatorSettings CreateNode(GRGEN_LGSP.LGSPGraph graph)
		{
			GRGEN_MODEL.@SimulatorSettings node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@SimulatorSettings();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of SimulatorSettings
				node.@state = 0;
				// explicit initializations of SimulatorSettings for target SimulatorSettings
			}
			graph.AddNode(node);
			return node;
		}

		public static GRGEN_MODEL.@SimulatorSettings CreateNode(GRGEN_LGSP.LGSPGraph graph, string varName)
		{
			GRGEN_MODEL.@SimulatorSettings node;
			if(poolLevel == 0)
				node = new GRGEN_MODEL.@SimulatorSettings();
			else
			{
				node = pool[--poolLevel];
				node.lgspInhead = null;
				node.lgspOuthead = null;
				node.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				// implicit initialization, map/set creation of SimulatorSettings
				node.@state = 0;
				// explicit initializations of SimulatorSettings for target SimulatorSettings
			}
			graph.AddNode(node, varName);
			return node;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private GRGEN_MODEL.ENUM_SimulatorState state\u0303;
		public GRGEN_MODEL.ENUM_SimulatorState @state
		{
			get { return state\u0303; }
			set { state\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "state": return this.@state;
			}
			throw new NullReferenceException(
				"The node type \"SimulatorSettings\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "state": this.@state = (GRGEN_MODEL.ENUM_SimulatorState) value; return;
			}
			throw new NullReferenceException(
				"The node type \"SimulatorSettings\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of SimulatorSettings
			this.@state = 0;
			// explicit initializations of SimulatorSettings for target SimulatorSettings
		}
	}

	public sealed class NodeType_SimulatorSettings : GRGEN_LIBGR.NodeType
	{
		public static GRGEN_MODEL.NodeType_SimulatorSettings typeVar = new GRGEN_MODEL.NodeType_SimulatorSettings();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public static GRGEN_LIBGR.AttributeType AttributeType_state;
		public NodeType_SimulatorSettings() : base((int) NodeTypes.@SimulatorSettings)
		{
			AttributeType_state = new GRGEN_LIBGR.AttributeType("state", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@SimulatorState, null, null, null);
		}
		public override string Name { get { return "SimulatorSettings"; } }
		public override string NodeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ISimulatorSettings"; } }
		public override string NodeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@SimulatorSettings"; } }
		public override GRGEN_LIBGR.INode CreateNode()
		{
			return new GRGEN_MODEL.@SimulatorSettings();
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_state;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "state" : return AttributeType_state;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.INode CreateNodeWithCopyCommons(GRGEN_LIBGR.INode oldINode)
		{
			GRGEN_LGSP.LGSPNode oldNode = (GRGEN_LGSP.LGSPNode) oldINode;
			GRGEN_MODEL.@SimulatorSettings newNode = new GRGEN_MODEL.@SimulatorSettings();
			switch(oldNode.Type.TypeID)
			{
				case (int) NodeTypes.@SimulatorSettings:
					// copy attributes for: SimulatorSettings
					{
						GRGEN_MODEL.ISimulatorSettings old = (GRGEN_MODEL.ISimulatorSettings) oldNode;
						newNode.@state = old.@state;
					}
					break;
			}
			return newNode;
		}

	}

	//
	// Node model
	//

	public sealed class BPMNNodeModel : GRGEN_LIBGR.INodeModel
	{
		public BPMNNodeModel()
		{
			GRGEN_MODEL.NodeType_Node.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_WorkflowProcess.typeVar,
				GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_ProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_Token.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
				GRGEN_MODEL.NodeType_HiddenToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar,
				GRGEN_MODEL.NodeType_HistoryToken.typeVar,
				GRGEN_MODEL.NodeType_UndoToken.typeVar,
				GRGEN_MODEL.NodeType_UndoneToken.typeVar,
				GRGEN_MODEL.NodeType_PException.typeVar,
				GRGEN_MODEL.NodeType_Task.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
				GRGEN_MODEL.NodeType_ActivitySet.typeVar,
				GRGEN_MODEL.NodeType_StartEvent.typeVar,
				GRGEN_MODEL.NodeType_EndEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
				GRGEN_MODEL.NodeType_Gateway.typeVar,
				GRGEN_MODEL.NodeType__Flow.typeVar,
				GRGEN_MODEL.NodeType__SequenceFlow.typeVar,
				GRGEN_MODEL.NodeType__MessageFlow.typeVar,
				GRGEN_MODEL.NodeType_dMarker.typeVar,
				GRGEN_MODEL.NodeType__Association.typeVar,
				GRGEN_MODEL.NodeType_Marking.typeVar,
				GRGEN_MODEL.NodeType_HighlightMarking.typeVar,
				GRGEN_MODEL.NodeType_MarkingFromLog.typeVar,
				GRGEN_MODEL.NodeType_MnextWithCause.typeVar,
				GRGEN_MODEL.NodeType_DummyInt.typeVar,
				GRGEN_MODEL.NodeType_SimulatorSettings.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_Marking.typeVar,
				GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
				GRGEN_MODEL.NodeType_PException.typeVar,
				GRGEN_MODEL.NodeType_dMarker.typeVar,
				GRGEN_MODEL.NodeType_MnextWithCause.typeVar,
				GRGEN_MODEL.NodeType_DummyInt.typeVar,
				GRGEN_MODEL.NodeType_SimulatorSettings.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Node.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Node.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_WorkflowProcess.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_WorkflowProcess.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_WorkflowProcess.typeVar,
			};
			GRGEN_MODEL.NodeType_WorkflowProcess.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_WorkflowProcess.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_WorkflowProcess.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_WorkflowProcess.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_WorkflowProcess.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
			};
			GRGEN_MODEL.NodeType_WorkflowProcess.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_WorkflowProcess.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
			};
			GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_ProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar,
			};
			GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_ProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar,
			};
			GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_ProcessInstance.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_ProcessInstance.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_ProcessInstance.typeVar,
			};
			GRGEN_MODEL.NodeType_ProcessInstance.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_ProcessInstance.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_ProcessInstance.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_ProcessInstance.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_ProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
			};
			GRGEN_MODEL.NodeType_ProcessInstance.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_ProcessInstance.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
			};
			GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar,
			};
			GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
			};
			GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
			};
			GRGEN_MODEL.NodeType_BaseElement.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BaseElement.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_WorkflowProcess.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Task.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
				GRGEN_MODEL.NodeType_ActivitySet.typeVar,
				GRGEN_MODEL.NodeType_StartEvent.typeVar,
				GRGEN_MODEL.NodeType_EndEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
				GRGEN_MODEL.NodeType_Gateway.typeVar,
				GRGEN_MODEL.NodeType__Flow.typeVar,
				GRGEN_MODEL.NodeType__SequenceFlow.typeVar,
				GRGEN_MODEL.NodeType__MessageFlow.typeVar,
				GRGEN_MODEL.NodeType__Association.typeVar,
			};
			GRGEN_MODEL.NodeType_BaseElement.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BaseElement.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
			};
			GRGEN_MODEL.NodeType_BaseElement.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BaseElement.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_BaseElement.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BaseElement.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_FlowElement.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_FlowElement.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Task.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
				GRGEN_MODEL.NodeType_StartEvent.typeVar,
				GRGEN_MODEL.NodeType_EndEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
				GRGEN_MODEL.NodeType_Gateway.typeVar,
				GRGEN_MODEL.NodeType__Flow.typeVar,
				GRGEN_MODEL.NodeType__SequenceFlow.typeVar,
				GRGEN_MODEL.NodeType__MessageFlow.typeVar,
				GRGEN_MODEL.NodeType__Association.typeVar,
			};
			GRGEN_MODEL.NodeType_FlowElement.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_FlowElement.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType__Flow.typeVar,
			};
			GRGEN_MODEL.NodeType_FlowElement.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_FlowElement.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
			};
			GRGEN_MODEL.NodeType_FlowElement.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_FlowElement.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
			};
			GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
				GRGEN_MODEL.NodeType_WorkflowProcess.typeVar,
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
				GRGEN_MODEL.NodeType_ActivitySet.typeVar,
			};
			GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_WorkflowProcess.typeVar,
				GRGEN_MODEL.NodeType_ActivitySet.typeVar,
			};
			GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
			};
			GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
			};
			GRGEN_MODEL.NodeType_Activity.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Activity.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Task.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
				GRGEN_MODEL.NodeType_StartEvent.typeVar,
				GRGEN_MODEL.NodeType_EndEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
				GRGEN_MODEL.NodeType_Gateway.typeVar,
			};
			GRGEN_MODEL.NodeType_Activity.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Activity.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Task.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
				GRGEN_MODEL.NodeType_Gateway.typeVar,
			};
			GRGEN_MODEL.NodeType_Activity.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Activity.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
			};
			GRGEN_MODEL.NodeType_Activity.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Activity.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
			};
			GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar,
			};
			GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar,
			};
			GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar,
			};
			GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
			};
			GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
			};
			GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar,
			};
			GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
			};
			GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
			};
			GRGEN_MODEL.NodeType_AbstrToken.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_AbstrToken.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_Token.typeVar,
				GRGEN_MODEL.NodeType_HiddenToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar,
				GRGEN_MODEL.NodeType_HistoryToken.typeVar,
				GRGEN_MODEL.NodeType_UndoToken.typeVar,
				GRGEN_MODEL.NodeType_UndoneToken.typeVar,
			};
			GRGEN_MODEL.NodeType_AbstrToken.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_AbstrToken.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Token.typeVar,
				GRGEN_MODEL.NodeType_HiddenToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar,
				GRGEN_MODEL.NodeType_HistoryToken.typeVar,
				GRGEN_MODEL.NodeType_UndoToken.typeVar,
				GRGEN_MODEL.NodeType_UndoneToken.typeVar,
			};
			GRGEN_MODEL.NodeType_AbstrToken.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_AbstrToken.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_AbstrToken.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_AbstrToken.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Token.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Token.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Token.typeVar,
			};
			GRGEN_MODEL.NodeType_Token.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Token.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Token.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Token.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Token.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			};
			GRGEN_MODEL.NodeType_Token.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Token.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenElement.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenElement.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
				GRGEN_MODEL.NodeType_HiddenToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenElement.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_HiddenElement.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenElement.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenElement.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenElement.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_HiddenElement.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenToken.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenToken.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenToken.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_HiddenToken.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_HiddenToken.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenToken.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenToken.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenToken.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_HiddenToken.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			};
			GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
				GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			};
			GRGEN_MODEL.NodeType_HistoryToken.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_HistoryToken.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HistoryToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HistoryToken.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_HistoryToken.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_HistoryToken.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_HistoryToken.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HistoryToken.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			};
			GRGEN_MODEL.NodeType_HistoryToken.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_HistoryToken.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			};
			GRGEN_MODEL.NodeType_UndoToken.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_UndoToken.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_UndoToken.typeVar,
			};
			GRGEN_MODEL.NodeType_UndoToken.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_UndoToken.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_UndoToken.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_UndoToken.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_UndoToken.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			};
			GRGEN_MODEL.NodeType_UndoToken.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_UndoToken.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			};
			GRGEN_MODEL.NodeType_UndoneToken.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_UndoneToken.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_UndoneToken.typeVar,
			};
			GRGEN_MODEL.NodeType_UndoneToken.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_UndoneToken.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_UndoneToken.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_UndoneToken.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_UndoneToken.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			};
			GRGEN_MODEL.NodeType_UndoneToken.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_UndoneToken.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			};
			GRGEN_MODEL.NodeType_PException.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_PException.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_PException.typeVar,
			};
			GRGEN_MODEL.NodeType_PException.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_PException.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_PException.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_PException.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_PException.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_PException.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_PException.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Task.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Task.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Task.typeVar,
			};
			GRGEN_MODEL.NodeType_Task.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Task.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Task.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Task.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Task.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
			};
			GRGEN_MODEL.NodeType_Task.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Task.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Activity.typeVar,
			};
			GRGEN_MODEL.NodeType_Event.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Event.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_StartEvent.typeVar,
				GRGEN_MODEL.NodeType_EndEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_Event.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Event.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_StartEvent.typeVar,
				GRGEN_MODEL.NodeType_EndEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_Event.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Event.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
			};
			GRGEN_MODEL.NodeType_Event.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Event.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Activity.typeVar,
			};
			GRGEN_MODEL.NodeType_BlockActivity.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_BlockActivity.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
			};
			GRGEN_MODEL.NodeType_BlockActivity.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_BlockActivity.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_BlockActivity.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_BlockActivity.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_ActivitySet.typeVar,
			};
			GRGEN_MODEL.NodeType_BlockActivity.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_BlockActivity.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_ActivitySet.typeVar,
			};
			GRGEN_MODEL.NodeType_ActivitySet.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_ActivitySet.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_ActivitySet.typeVar,
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
			};
			GRGEN_MODEL.NodeType_ActivitySet.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_ActivitySet.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_BlockActivity.typeVar,
			};
			GRGEN_MODEL.NodeType_ActivitySet.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_ActivitySet.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_ActivitySet.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
			};
			GRGEN_MODEL.NodeType_ActivitySet.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_ActivitySet.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
			};
			GRGEN_MODEL.NodeType_StartEvent.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_StartEvent.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_StartEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_StartEvent.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_StartEvent.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_StartEvent.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_StartEvent.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_StartEvent.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
			};
			GRGEN_MODEL.NodeType_StartEvent.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_StartEvent.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Event.typeVar,
			};
			GRGEN_MODEL.NodeType_EndEvent.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_EndEvent.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_EndEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_EndEvent.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_EndEvent.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_EndEvent.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_EndEvent.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_EndEvent.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
			};
			GRGEN_MODEL.NodeType_EndEvent.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_EndEvent.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Event.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateEvent.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_IntermediateEvent.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateEvent.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_IntermediateEvent.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateEvent.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_IntermediateEvent.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateEvent.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_IntermediateEvent.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Event.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
				GRGEN_MODEL.NodeType_Event.typeVar,
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
			};
			GRGEN_MODEL.NodeType_Gateway.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Gateway.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Gateway.typeVar,
			};
			GRGEN_MODEL.NodeType_Gateway.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Gateway.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_Gateway.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Gateway.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Gateway.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType_Activity.typeVar,
			};
			GRGEN_MODEL.NodeType_Gateway.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Gateway.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Activity.typeVar,
			};
			GRGEN_MODEL.NodeType__Flow.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType__Flow.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__Flow.typeVar,
				GRGEN_MODEL.NodeType__SequenceFlow.typeVar,
				GRGEN_MODEL.NodeType__MessageFlow.typeVar,
				GRGEN_MODEL.NodeType__Association.typeVar,
			};
			GRGEN_MODEL.NodeType__Flow.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType__Flow.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__SequenceFlow.typeVar,
				GRGEN_MODEL.NodeType__MessageFlow.typeVar,
				GRGEN_MODEL.NodeType__Association.typeVar,
			};
			GRGEN_MODEL.NodeType__Flow.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType__Flow.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__Flow.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
			};
			GRGEN_MODEL.NodeType__Flow.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType__Flow.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
			};
			GRGEN_MODEL.NodeType__SequenceFlow.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType__SequenceFlow.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__SequenceFlow.typeVar,
			};
			GRGEN_MODEL.NodeType__SequenceFlow.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType__SequenceFlow.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType__SequenceFlow.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType__SequenceFlow.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__SequenceFlow.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType__Flow.typeVar,
			};
			GRGEN_MODEL.NodeType__SequenceFlow.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType__SequenceFlow.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__Flow.typeVar,
			};
			GRGEN_MODEL.NodeType__MessageFlow.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType__MessageFlow.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__MessageFlow.typeVar,
			};
			GRGEN_MODEL.NodeType__MessageFlow.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType__MessageFlow.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType__MessageFlow.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType__MessageFlow.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__MessageFlow.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType__Flow.typeVar,
			};
			GRGEN_MODEL.NodeType__MessageFlow.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType__MessageFlow.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__Flow.typeVar,
			};
			GRGEN_MODEL.NodeType_dMarker.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_dMarker.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_dMarker.typeVar,
			};
			GRGEN_MODEL.NodeType_dMarker.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_dMarker.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_dMarker.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_dMarker.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_dMarker.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_dMarker.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_dMarker.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType__Association.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType__Association.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__Association.typeVar,
			};
			GRGEN_MODEL.NodeType__Association.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType__Association.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType__Association.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType__Association.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__Association.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_BaseElement.typeVar,
				GRGEN_MODEL.NodeType_FlowElement.typeVar,
				GRGEN_MODEL.NodeType__Flow.typeVar,
			};
			GRGEN_MODEL.NodeType__Association.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType__Association.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType__Flow.typeVar,
			};
			GRGEN_MODEL.NodeType_Marking.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_Marking.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Marking.typeVar,
				GRGEN_MODEL.NodeType_HighlightMarking.typeVar,
				GRGEN_MODEL.NodeType_MarkingFromLog.typeVar,
			};
			GRGEN_MODEL.NodeType_Marking.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_Marking.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HighlightMarking.typeVar,
				GRGEN_MODEL.NodeType_MarkingFromLog.typeVar,
			};
			GRGEN_MODEL.NodeType_Marking.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_Marking.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Marking.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_Marking.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_Marking.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_HighlightMarking.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_HighlightMarking.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HighlightMarking.typeVar,
			};
			GRGEN_MODEL.NodeType_HighlightMarking.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_HighlightMarking.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_HighlightMarking.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_HighlightMarking.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_HighlightMarking.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_Marking.typeVar,
			};
			GRGEN_MODEL.NodeType_HighlightMarking.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_HighlightMarking.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Marking.typeVar,
			};
			GRGEN_MODEL.NodeType_MarkingFromLog.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_MarkingFromLog.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_MarkingFromLog.typeVar,
			};
			GRGEN_MODEL.NodeType_MarkingFromLog.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_MarkingFromLog.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_MarkingFromLog.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_MarkingFromLog.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_MarkingFromLog.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
				GRGEN_MODEL.NodeType_Marking.typeVar,
			};
			GRGEN_MODEL.NodeType_MarkingFromLog.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_MarkingFromLog.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Marking.typeVar,
			};
			GRGEN_MODEL.NodeType_MnextWithCause.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_MnextWithCause.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_MnextWithCause.typeVar,
			};
			GRGEN_MODEL.NodeType_MnextWithCause.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_MnextWithCause.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_MnextWithCause.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_MnextWithCause.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_MnextWithCause.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_MnextWithCause.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_MnextWithCause.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_DummyInt.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_DummyInt.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DummyInt.typeVar,
			};
			GRGEN_MODEL.NodeType_DummyInt.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_DummyInt.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_DummyInt.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_DummyInt.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_DummyInt.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_DummyInt.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_DummyInt.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_SimulatorSettings.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.NodeType_SimulatorSettings.typeVar.subOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_SimulatorSettings.typeVar,
			};
			GRGEN_MODEL.NodeType_SimulatorSettings.typeVar.directSubGrGenTypes = GRGEN_MODEL.NodeType_SimulatorSettings.typeVar.directSubTypes = new GRGEN_LIBGR.NodeType[] {
			};
			GRGEN_MODEL.NodeType_SimulatorSettings.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.NodeType_SimulatorSettings.typeVar.superOrSameTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_SimulatorSettings.typeVar,
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
			GRGEN_MODEL.NodeType_SimulatorSettings.typeVar.directSuperGrGenTypes = GRGEN_MODEL.NodeType_SimulatorSettings.typeVar.directSuperTypes = new GRGEN_LIBGR.NodeType[] {
				GRGEN_MODEL.NodeType_Node.typeVar,
			};
		}
		public bool IsNodeModel { get { return true; } }
		public GRGEN_LIBGR.NodeType RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		GRGEN_LIBGR.GrGenType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.NodeType_Node.typeVar; } }
		public GRGEN_LIBGR.NodeType GetType(string name)
		{
			switch(name)
			{
				case "Node" : return GRGEN_MODEL.NodeType_Node.typeVar;
				case "WorkflowProcess" : return GRGEN_MODEL.NodeType_WorkflowProcess.typeVar;
				case "AbstrProcessInstance" : return GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar;
				case "ProcessInstance" : return GRGEN_MODEL.NodeType_ProcessInstance.typeVar;
				case "VisibleProcessInstance" : return GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar;
				case "BaseElement" : return GRGEN_MODEL.NodeType_BaseElement.typeVar;
				case "FlowElement" : return GRGEN_MODEL.NodeType_FlowElement.typeVar;
				case "FlowElementsContainer" : return GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar;
				case "Activity" : return GRGEN_MODEL.NodeType_Activity.typeVar;
				case "LoopCharacteristics" : return GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar;
				case "StandardLoopCharacteristics" : return GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar;
				case "MultipleInstanceLoopCharacteristics" : return GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar;
				case "AbstrToken" : return GRGEN_MODEL.NodeType_AbstrToken.typeVar;
				case "Token" : return GRGEN_MODEL.NodeType_Token.typeVar;
				case "HiddenElement" : return GRGEN_MODEL.NodeType_HiddenElement.typeVar;
				case "HiddenToken" : return GRGEN_MODEL.NodeType_HiddenToken.typeVar;
				case "HiddenHistoryToken" : return GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar;
				case "HiddenUndoToken" : return GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar;
				case "HiddenUndoneToken" : return GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar;
				case "HistoryToken" : return GRGEN_MODEL.NodeType_HistoryToken.typeVar;
				case "UndoToken" : return GRGEN_MODEL.NodeType_UndoToken.typeVar;
				case "UndoneToken" : return GRGEN_MODEL.NodeType_UndoneToken.typeVar;
				case "PException" : return GRGEN_MODEL.NodeType_PException.typeVar;
				case "Task" : return GRGEN_MODEL.NodeType_Task.typeVar;
				case "Event" : return GRGEN_MODEL.NodeType_Event.typeVar;
				case "BlockActivity" : return GRGEN_MODEL.NodeType_BlockActivity.typeVar;
				case "ActivitySet" : return GRGEN_MODEL.NodeType_ActivitySet.typeVar;
				case "StartEvent" : return GRGEN_MODEL.NodeType_StartEvent.typeVar;
				case "EndEvent" : return GRGEN_MODEL.NodeType_EndEvent.typeVar;
				case "IntermediateEvent" : return GRGEN_MODEL.NodeType_IntermediateEvent.typeVar;
				case "IntermediateCatchEvent" : return GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar;
				case "IntermediateThrowEvent" : return GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar;
				case "Gateway" : return GRGEN_MODEL.NodeType_Gateway.typeVar;
				case "_Flow" : return GRGEN_MODEL.NodeType__Flow.typeVar;
				case "_SequenceFlow" : return GRGEN_MODEL.NodeType__SequenceFlow.typeVar;
				case "_MessageFlow" : return GRGEN_MODEL.NodeType__MessageFlow.typeVar;
				case "dMarker" : return GRGEN_MODEL.NodeType_dMarker.typeVar;
				case "_Association" : return GRGEN_MODEL.NodeType__Association.typeVar;
				case "Marking" : return GRGEN_MODEL.NodeType_Marking.typeVar;
				case "HighlightMarking" : return GRGEN_MODEL.NodeType_HighlightMarking.typeVar;
				case "MarkingFromLog" : return GRGEN_MODEL.NodeType_MarkingFromLog.typeVar;
				case "MnextWithCause" : return GRGEN_MODEL.NodeType_MnextWithCause.typeVar;
				case "DummyInt" : return GRGEN_MODEL.NodeType_DummyInt.typeVar;
				case "SimulatorSettings" : return GRGEN_MODEL.NodeType_SimulatorSettings.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.GrGenType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.NodeType[] types = {
			GRGEN_MODEL.NodeType_Node.typeVar,
			GRGEN_MODEL.NodeType_WorkflowProcess.typeVar,
			GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar,
			GRGEN_MODEL.NodeType_ProcessInstance.typeVar,
			GRGEN_MODEL.NodeType_VisibleProcessInstance.typeVar,
			GRGEN_MODEL.NodeType_BaseElement.typeVar,
			GRGEN_MODEL.NodeType_FlowElement.typeVar,
			GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar,
			GRGEN_MODEL.NodeType_Activity.typeVar,
			GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar,
			GRGEN_MODEL.NodeType_StandardLoopCharacteristics.typeVar,
			GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.typeVar,
			GRGEN_MODEL.NodeType_AbstrToken.typeVar,
			GRGEN_MODEL.NodeType_Token.typeVar,
			GRGEN_MODEL.NodeType_HiddenElement.typeVar,
			GRGEN_MODEL.NodeType_HiddenToken.typeVar,
			GRGEN_MODEL.NodeType_HiddenHistoryToken.typeVar,
			GRGEN_MODEL.NodeType_HiddenUndoToken.typeVar,
			GRGEN_MODEL.NodeType_HiddenUndoneToken.typeVar,
			GRGEN_MODEL.NodeType_HistoryToken.typeVar,
			GRGEN_MODEL.NodeType_UndoToken.typeVar,
			GRGEN_MODEL.NodeType_UndoneToken.typeVar,
			GRGEN_MODEL.NodeType_PException.typeVar,
			GRGEN_MODEL.NodeType_Task.typeVar,
			GRGEN_MODEL.NodeType_Event.typeVar,
			GRGEN_MODEL.NodeType_BlockActivity.typeVar,
			GRGEN_MODEL.NodeType_ActivitySet.typeVar,
			GRGEN_MODEL.NodeType_StartEvent.typeVar,
			GRGEN_MODEL.NodeType_EndEvent.typeVar,
			GRGEN_MODEL.NodeType_IntermediateEvent.typeVar,
			GRGEN_MODEL.NodeType_IntermediateCatchEvent.typeVar,
			GRGEN_MODEL.NodeType_IntermediateThrowEvent.typeVar,
			GRGEN_MODEL.NodeType_Gateway.typeVar,
			GRGEN_MODEL.NodeType__Flow.typeVar,
			GRGEN_MODEL.NodeType__SequenceFlow.typeVar,
			GRGEN_MODEL.NodeType__MessageFlow.typeVar,
			GRGEN_MODEL.NodeType_dMarker.typeVar,
			GRGEN_MODEL.NodeType__Association.typeVar,
			GRGEN_MODEL.NodeType_Marking.typeVar,
			GRGEN_MODEL.NodeType_HighlightMarking.typeVar,
			GRGEN_MODEL.NodeType_MarkingFromLog.typeVar,
			GRGEN_MODEL.NodeType_MnextWithCause.typeVar,
			GRGEN_MODEL.NodeType_DummyInt.typeVar,
			GRGEN_MODEL.NodeType_SimulatorSettings.typeVar,
		};
		public GRGEN_LIBGR.NodeType[] Types { get { return types; } }
		GRGEN_LIBGR.GrGenType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.NodeType_Node),
			typeof(GRGEN_MODEL.NodeType_WorkflowProcess),
			typeof(GRGEN_MODEL.NodeType_AbstrProcessInstance),
			typeof(GRGEN_MODEL.NodeType_ProcessInstance),
			typeof(GRGEN_MODEL.NodeType_VisibleProcessInstance),
			typeof(GRGEN_MODEL.NodeType_BaseElement),
			typeof(GRGEN_MODEL.NodeType_FlowElement),
			typeof(GRGEN_MODEL.NodeType_FlowElementsContainer),
			typeof(GRGEN_MODEL.NodeType_Activity),
			typeof(GRGEN_MODEL.NodeType_LoopCharacteristics),
			typeof(GRGEN_MODEL.NodeType_StandardLoopCharacteristics),
			typeof(GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics),
			typeof(GRGEN_MODEL.NodeType_AbstrToken),
			typeof(GRGEN_MODEL.NodeType_Token),
			typeof(GRGEN_MODEL.NodeType_HiddenElement),
			typeof(GRGEN_MODEL.NodeType_HiddenToken),
			typeof(GRGEN_MODEL.NodeType_HiddenHistoryToken),
			typeof(GRGEN_MODEL.NodeType_HiddenUndoToken),
			typeof(GRGEN_MODEL.NodeType_HiddenUndoneToken),
			typeof(GRGEN_MODEL.NodeType_HistoryToken),
			typeof(GRGEN_MODEL.NodeType_UndoToken),
			typeof(GRGEN_MODEL.NodeType_UndoneToken),
			typeof(GRGEN_MODEL.NodeType_PException),
			typeof(GRGEN_MODEL.NodeType_Task),
			typeof(GRGEN_MODEL.NodeType_Event),
			typeof(GRGEN_MODEL.NodeType_BlockActivity),
			typeof(GRGEN_MODEL.NodeType_ActivitySet),
			typeof(GRGEN_MODEL.NodeType_StartEvent),
			typeof(GRGEN_MODEL.NodeType_EndEvent),
			typeof(GRGEN_MODEL.NodeType_IntermediateEvent),
			typeof(GRGEN_MODEL.NodeType_IntermediateCatchEvent),
			typeof(GRGEN_MODEL.NodeType_IntermediateThrowEvent),
			typeof(GRGEN_MODEL.NodeType_Gateway),
			typeof(GRGEN_MODEL.NodeType__Flow),
			typeof(GRGEN_MODEL.NodeType__SequenceFlow),
			typeof(GRGEN_MODEL.NodeType__MessageFlow),
			typeof(GRGEN_MODEL.NodeType_dMarker),
			typeof(GRGEN_MODEL.NodeType__Association),
			typeof(GRGEN_MODEL.NodeType_Marking),
			typeof(GRGEN_MODEL.NodeType_HighlightMarking),
			typeof(GRGEN_MODEL.NodeType_MarkingFromLog),
			typeof(GRGEN_MODEL.NodeType_MnextWithCause),
			typeof(GRGEN_MODEL.NodeType_DummyInt),
			typeof(GRGEN_MODEL.NodeType_SimulatorSettings),
		};
		public System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
			GRGEN_MODEL.NodeType_AbstrProcessInstance.AttributeType_state,
			GRGEN_MODEL.NodeType_Activity.AttributeType_Name,
			GRGEN_MODEL.NodeType_Activity.AttributeType__nOut,
			GRGEN_MODEL.NodeType_StandardLoopCharacteristics.AttributeType_TestBefore,
			GRGEN_MODEL.NodeType_MultipleInstanceLoopCharacteristics.AttributeType_isSequential,
			GRGEN_MODEL.NodeType_Event.AttributeType_EventDefinitionName,
			GRGEN_MODEL.NodeType_Event.AttributeType_ErrorCode,
			GRGEN_MODEL.NodeType_Event.AttributeType_Trigger,
			GRGEN_MODEL.NodeType_Event.AttributeType_Result,
			GRGEN_MODEL.NodeType_Event.AttributeType_cancelActivity,
			GRGEN_MODEL.NodeType_StartEvent.AttributeType__triggeredAutonomously,
			GRGEN_MODEL.NodeType_Gateway.AttributeType_GatewayType,
			GRGEN_MODEL.NodeType_Gateway.AttributeType_ExclusiveType,
			GRGEN_MODEL.NodeType_Gateway.AttributeType_Instantiate,
			GRGEN_MODEL.NodeType__SequenceFlow.AttributeType_Type,
			GRGEN_MODEL.NodeType__Association.AttributeType_Name,
			GRGEN_MODEL.NodeType_MnextWithCause.AttributeType_ruleName,
			GRGEN_MODEL.NodeType_DummyInt.AttributeType_val,
			GRGEN_MODEL.NodeType_SimulatorSettings.AttributeType_state,
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// Edge types
	//

	public enum EdgeTypes { @AEdge, @Edge, @UEdge, @instatespace, @parent2subPI, @instOf, @pi2mark, @flowElements, @activityRef, @loopCharacteristics, @tok2pi, @pi2exc, @itokens, @Tokens, @activities, @sequenceflows, @SequenceFlow, @Tok2Tok, @TokCopyOf, @CopiedTo, @dFlow, @_From, @_To, @Association, @Melem, @Mnext, @_FromMarking, @_ToMarking, @_Cause, @MreplayOf, @Target, @Contains };

	// *** Edge AEdge ***


	public sealed class EdgeType_AEdge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_AEdge typeVar = new GRGEN_MODEL.EdgeType_AEdge();
		public static bool[] isA = new bool[] { true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
		public EdgeType_AEdge() : base((int) EdgeTypes.@AEdge)
		{
		}
		public override string Name { get { return "AEdge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IEdge"; } }
		public override string EdgeClassName { get { return null; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Arbitrary; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			throw new Exception("The abstract edge type AEdge cannot be instantiated!");
		}
		public override bool IsAbstract { get { return true; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			throw new Exception("Cannot retype to the abstract type AEdge!");
		}
	}

	// *** Edge Edge ***


	public sealed class @Edge : GRGEN_LGSP.LGSPEdge, GRGEN_LIBGR.IEdge
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Edge[] pool = new GRGEN_MODEL.@Edge[10];
		
		static @Edge() {
		}
		
		public @Edge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Edge.typeVar, source, target)
		{
			// implicit initialization, map/set creation of Edge
		}

		public static GRGEN_MODEL.EdgeType_Edge TypeInstance { get { return GRGEN_MODEL.EdgeType_Edge.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Edge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Edge(GRGEN_MODEL.@Edge oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Edge.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@Edge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Edge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Edge(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Edge
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Edge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@Edge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Edge(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Edge
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"Edge\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"Edge\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Edge
		}
	}

	public sealed class EdgeType_Edge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Edge typeVar = new GRGEN_MODEL.EdgeType_Edge();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, };
		public EdgeType_Edge() : base((int) EdgeTypes.@Edge)
		{
		}
		public override string Name { get { return "Edge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IEdge"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Edge"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Edge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Edge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge UEdge ***


	public sealed class @UEdge : GRGEN_LGSP.LGSPEdge, GRGEN_LIBGR.IEdge
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@UEdge[] pool = new GRGEN_MODEL.@UEdge[10];
		
		static @UEdge() {
		}
		
		public @UEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_UEdge.typeVar, source, target)
		{
			// implicit initialization, map/set creation of UEdge
		}

		public static GRGEN_MODEL.EdgeType_UEdge TypeInstance { get { return GRGEN_MODEL.EdgeType_UEdge.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@UEdge(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @UEdge(GRGEN_MODEL.@UEdge oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_UEdge.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@UEdge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@UEdge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@UEdge(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of UEdge
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@UEdge CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@UEdge edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@UEdge(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of UEdge
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"UEdge\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"UEdge\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of UEdge
		}
	}

	public sealed class EdgeType_UEdge : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_UEdge typeVar = new GRGEN_MODEL.EdgeType_UEdge();
		public static bool[] isA = new bool[] { true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_UEdge() : base((int) EdgeTypes.@UEdge)
		{
		}
		public override string Name { get { return "UEdge"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.libGr.IEdge"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@UEdge"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Undirected; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@UEdge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@UEdge((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge instatespace ***

	public interface Iinstatespace : GRGEN_LIBGR.IEdge
	{
		string @rName { get; set; }
	}

	public sealed class @instatespace : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Iinstatespace
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@instatespace[] pool = new GRGEN_MODEL.@instatespace[10];
		
		// explicit initializations of instatespace for target instatespace
		// implicit initializations of instatespace for target instatespace
		static @instatespace() {
		}
		
		public @instatespace(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_instatespace.typeVar, source, target)
		{
			// implicit initialization, map/set creation of instatespace
			// explicit initializations of instatespace for target instatespace
		}

		public static GRGEN_MODEL.EdgeType_instatespace TypeInstance { get { return GRGEN_MODEL.EdgeType_instatespace.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@instatespace(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @instatespace(GRGEN_MODEL.@instatespace oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_instatespace.typeVar, newSource, newTarget)
		{
			rName\u0303 = oldElem.rName\u0303;
		}
		public static GRGEN_MODEL.@instatespace CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@instatespace edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@instatespace(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of instatespace
				edge.@rName = null;
				// explicit initializations of instatespace for target instatespace
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@instatespace CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@instatespace edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@instatespace(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of instatespace
				edge.@rName = null;
				// explicit initializations of instatespace for target instatespace
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string rName\u0303;
		public string @rName
		{
			get { return rName\u0303; }
			set { rName\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "rName": return this.@rName;
			}
			throw new NullReferenceException(
				"The edge type \"instatespace\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "rName": this.@rName = (string) value; return;
			}
			throw new NullReferenceException(
				"The edge type \"instatespace\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of instatespace
			this.@rName = null;
			// explicit initializations of instatespace for target instatespace
		}
	}

	public sealed class EdgeType_instatespace : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_instatespace typeVar = new GRGEN_MODEL.EdgeType_instatespace();
		public static bool[] isA = new bool[] { true, true, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_rName;
		public EdgeType_instatespace() : base((int) EdgeTypes.@instatespace)
		{
			AttributeType_rName = new GRGEN_LIBGR.AttributeType("rName", this, GRGEN_LIBGR.AttributeKind.StringAttr, null, null, null, null);
		}
		public override string Name { get { return "instatespace"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.Iinstatespace"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@instatespace"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@instatespace((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_rName;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "rName" : return AttributeType_rName;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			GRGEN_LGSP.LGSPEdge oldEdge = (GRGEN_LGSP.LGSPEdge) oldIEdge;
			GRGEN_MODEL.@instatespace newEdge = new GRGEN_MODEL.@instatespace((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
			switch(oldEdge.Type.TypeID)
			{
				case (int) EdgeTypes.@instatespace:
					// copy attributes for: instatespace
					{
						GRGEN_MODEL.Iinstatespace old = (GRGEN_MODEL.Iinstatespace) oldEdge;
						newEdge.@rName = old.@rName;
					}
					break;
			}
			return newEdge;
		}

	}

	// *** Edge parent2subPI ***

	public interface Iparent2subPI : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @parent2subPI : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Iparent2subPI
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@parent2subPI[] pool = new GRGEN_MODEL.@parent2subPI[10];
		
		// explicit initializations of parent2subPI for target parent2subPI
		// implicit initializations of parent2subPI for target parent2subPI
		static @parent2subPI() {
		}
		
		public @parent2subPI(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_parent2subPI.typeVar, source, target)
		{
			// implicit initialization, map/set creation of parent2subPI
			// explicit initializations of parent2subPI for target parent2subPI
		}

		public static GRGEN_MODEL.EdgeType_parent2subPI TypeInstance { get { return GRGEN_MODEL.EdgeType_parent2subPI.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@parent2subPI(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @parent2subPI(GRGEN_MODEL.@parent2subPI oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_parent2subPI.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@parent2subPI CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@parent2subPI edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@parent2subPI(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of parent2subPI
				// explicit initializations of parent2subPI for target parent2subPI
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@parent2subPI CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@parent2subPI edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@parent2subPI(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of parent2subPI
				// explicit initializations of parent2subPI for target parent2subPI
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"parent2subPI\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"parent2subPI\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of parent2subPI
			// explicit initializations of parent2subPI for target parent2subPI
		}
	}

	public sealed class EdgeType_parent2subPI : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_parent2subPI typeVar = new GRGEN_MODEL.EdgeType_parent2subPI();
		public static bool[] isA = new bool[] { true, true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_parent2subPI() : base((int) EdgeTypes.@parent2subPI)
		{
		}
		public override string Name { get { return "parent2subPI"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.Iparent2subPI"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@parent2subPI"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@parent2subPI((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@parent2subPI((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge instOf ***

	public interface IinstOf : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @instOf : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IinstOf
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@instOf[] pool = new GRGEN_MODEL.@instOf[10];
		
		// explicit initializations of instOf for target instOf
		// implicit initializations of instOf for target instOf
		static @instOf() {
		}
		
		public @instOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_instOf.typeVar, source, target)
		{
			// implicit initialization, map/set creation of instOf
			// explicit initializations of instOf for target instOf
		}

		public static GRGEN_MODEL.EdgeType_instOf TypeInstance { get { return GRGEN_MODEL.EdgeType_instOf.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@instOf(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @instOf(GRGEN_MODEL.@instOf oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_instOf.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@instOf CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@instOf edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@instOf(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of instOf
				// explicit initializations of instOf for target instOf
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@instOf CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@instOf edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@instOf(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of instOf
				// explicit initializations of instOf for target instOf
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"instOf\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"instOf\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of instOf
			// explicit initializations of instOf for target instOf
		}
	}

	public sealed class EdgeType_instOf : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_instOf typeVar = new GRGEN_MODEL.EdgeType_instOf();
		public static bool[] isA = new bool[] { true, true, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_instOf() : base((int) EdgeTypes.@instOf)
		{
		}
		public override string Name { get { return "instOf"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IinstOf"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@instOf"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@instOf((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@instOf((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge pi2mark ***

	public interface Ipi2mark : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @pi2mark : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Ipi2mark
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@pi2mark[] pool = new GRGEN_MODEL.@pi2mark[10];
		
		// explicit initializations of pi2mark for target pi2mark
		// implicit initializations of pi2mark for target pi2mark
		static @pi2mark() {
		}
		
		public @pi2mark(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_pi2mark.typeVar, source, target)
		{
			// implicit initialization, map/set creation of pi2mark
			// explicit initializations of pi2mark for target pi2mark
		}

		public static GRGEN_MODEL.EdgeType_pi2mark TypeInstance { get { return GRGEN_MODEL.EdgeType_pi2mark.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@pi2mark(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @pi2mark(GRGEN_MODEL.@pi2mark oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_pi2mark.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@pi2mark CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@pi2mark edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@pi2mark(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of pi2mark
				// explicit initializations of pi2mark for target pi2mark
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@pi2mark CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@pi2mark edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@pi2mark(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of pi2mark
				// explicit initializations of pi2mark for target pi2mark
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"pi2mark\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"pi2mark\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of pi2mark
			// explicit initializations of pi2mark for target pi2mark
		}
	}

	public sealed class EdgeType_pi2mark : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_pi2mark typeVar = new GRGEN_MODEL.EdgeType_pi2mark();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_pi2mark() : base((int) EdgeTypes.@pi2mark)
		{
		}
		public override string Name { get { return "pi2mark"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.Ipi2mark"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@pi2mark"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@pi2mark((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@pi2mark((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge flowElements ***

	public interface IflowElements : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @flowElements : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IflowElements
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@flowElements[] pool = new GRGEN_MODEL.@flowElements[10];
		
		// explicit initializations of flowElements for target flowElements
		// implicit initializations of flowElements for target flowElements
		static @flowElements() {
		}
		
		public @flowElements(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_flowElements.typeVar, source, target)
		{
			// implicit initialization, map/set creation of flowElements
			// explicit initializations of flowElements for target flowElements
		}

		public static GRGEN_MODEL.EdgeType_flowElements TypeInstance { get { return GRGEN_MODEL.EdgeType_flowElements.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@flowElements(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @flowElements(GRGEN_MODEL.@flowElements oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_flowElements.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@flowElements CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@flowElements edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@flowElements(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of flowElements
				// explicit initializations of flowElements for target flowElements
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@flowElements CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@flowElements edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@flowElements(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of flowElements
				// explicit initializations of flowElements for target flowElements
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"flowElements\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"flowElements\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of flowElements
			// explicit initializations of flowElements for target flowElements
		}
	}

	public sealed class EdgeType_flowElements : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_flowElements typeVar = new GRGEN_MODEL.EdgeType_flowElements();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_flowElements() : base((int) EdgeTypes.@flowElements)
		{
		}
		public override string Name { get { return "flowElements"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IflowElements"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@flowElements"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@flowElements((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@flowElements((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge activityRef ***

	public interface IactivityRef : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @activityRef : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IactivityRef
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@activityRef[] pool = new GRGEN_MODEL.@activityRef[10];
		
		// explicit initializations of activityRef for target activityRef
		// implicit initializations of activityRef for target activityRef
		static @activityRef() {
		}
		
		public @activityRef(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_activityRef.typeVar, source, target)
		{
			// implicit initialization, map/set creation of activityRef
			// explicit initializations of activityRef for target activityRef
		}

		public static GRGEN_MODEL.EdgeType_activityRef TypeInstance { get { return GRGEN_MODEL.EdgeType_activityRef.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@activityRef(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @activityRef(GRGEN_MODEL.@activityRef oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_activityRef.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@activityRef CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@activityRef edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@activityRef(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of activityRef
				// explicit initializations of activityRef for target activityRef
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@activityRef CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@activityRef edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@activityRef(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of activityRef
				// explicit initializations of activityRef for target activityRef
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"activityRef\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"activityRef\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of activityRef
			// explicit initializations of activityRef for target activityRef
		}
	}

	public sealed class EdgeType_activityRef : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_activityRef typeVar = new GRGEN_MODEL.EdgeType_activityRef();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_activityRef() : base((int) EdgeTypes.@activityRef)
		{
		}
		public override string Name { get { return "activityRef"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IactivityRef"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@activityRef"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@activityRef((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@activityRef((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge loopCharacteristics ***

	public interface IloopCharacteristics : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @loopCharacteristics : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IloopCharacteristics
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@loopCharacteristics[] pool = new GRGEN_MODEL.@loopCharacteristics[10];
		
		// explicit initializations of loopCharacteristics for target loopCharacteristics
		// implicit initializations of loopCharacteristics for target loopCharacteristics
		static @loopCharacteristics() {
		}
		
		public @loopCharacteristics(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar, source, target)
		{
			// implicit initialization, map/set creation of loopCharacteristics
			// explicit initializations of loopCharacteristics for target loopCharacteristics
		}

		public static GRGEN_MODEL.EdgeType_loopCharacteristics TypeInstance { get { return GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@loopCharacteristics(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @loopCharacteristics(GRGEN_MODEL.@loopCharacteristics oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@loopCharacteristics CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@loopCharacteristics edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@loopCharacteristics(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of loopCharacteristics
				// explicit initializations of loopCharacteristics for target loopCharacteristics
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@loopCharacteristics CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@loopCharacteristics edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@loopCharacteristics(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of loopCharacteristics
				// explicit initializations of loopCharacteristics for target loopCharacteristics
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"loopCharacteristics\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"loopCharacteristics\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of loopCharacteristics
			// explicit initializations of loopCharacteristics for target loopCharacteristics
		}
	}

	public sealed class EdgeType_loopCharacteristics : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_loopCharacteristics typeVar = new GRGEN_MODEL.EdgeType_loopCharacteristics();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_loopCharacteristics() : base((int) EdgeTypes.@loopCharacteristics)
		{
		}
		public override string Name { get { return "loopCharacteristics"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IloopCharacteristics"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@loopCharacteristics"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@loopCharacteristics((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@loopCharacteristics((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge tok2pi ***

	public interface Itok2pi : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @tok2pi : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Itok2pi
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@tok2pi[] pool = new GRGEN_MODEL.@tok2pi[10];
		
		// explicit initializations of tok2pi for target tok2pi
		// implicit initializations of tok2pi for target tok2pi
		static @tok2pi() {
		}
		
		public @tok2pi(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_tok2pi.typeVar, source, target)
		{
			// implicit initialization, map/set creation of tok2pi
			// explicit initializations of tok2pi for target tok2pi
		}

		public static GRGEN_MODEL.EdgeType_tok2pi TypeInstance { get { return GRGEN_MODEL.EdgeType_tok2pi.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@tok2pi(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @tok2pi(GRGEN_MODEL.@tok2pi oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_tok2pi.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@tok2pi CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@tok2pi edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@tok2pi(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of tok2pi
				// explicit initializations of tok2pi for target tok2pi
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@tok2pi CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@tok2pi edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@tok2pi(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of tok2pi
				// explicit initializations of tok2pi for target tok2pi
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"tok2pi\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"tok2pi\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of tok2pi
			// explicit initializations of tok2pi for target tok2pi
		}
	}

	public sealed class EdgeType_tok2pi : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_tok2pi typeVar = new GRGEN_MODEL.EdgeType_tok2pi();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_tok2pi() : base((int) EdgeTypes.@tok2pi)
		{
		}
		public override string Name { get { return "tok2pi"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.Itok2pi"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@tok2pi"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@tok2pi((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@tok2pi((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge pi2exc ***

	public interface Ipi2exc : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @pi2exc : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Ipi2exc
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@pi2exc[] pool = new GRGEN_MODEL.@pi2exc[10];
		
		// explicit initializations of pi2exc for target pi2exc
		// implicit initializations of pi2exc for target pi2exc
		static @pi2exc() {
		}
		
		public @pi2exc(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_pi2exc.typeVar, source, target)
		{
			// implicit initialization, map/set creation of pi2exc
			// explicit initializations of pi2exc for target pi2exc
		}

		public static GRGEN_MODEL.EdgeType_pi2exc TypeInstance { get { return GRGEN_MODEL.EdgeType_pi2exc.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@pi2exc(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @pi2exc(GRGEN_MODEL.@pi2exc oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_pi2exc.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@pi2exc CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@pi2exc edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@pi2exc(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of pi2exc
				// explicit initializations of pi2exc for target pi2exc
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@pi2exc CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@pi2exc edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@pi2exc(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of pi2exc
				// explicit initializations of pi2exc for target pi2exc
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"pi2exc\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"pi2exc\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of pi2exc
			// explicit initializations of pi2exc for target pi2exc
		}
	}

	public sealed class EdgeType_pi2exc : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_pi2exc typeVar = new GRGEN_MODEL.EdgeType_pi2exc();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_pi2exc() : base((int) EdgeTypes.@pi2exc)
		{
		}
		public override string Name { get { return "pi2exc"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.Ipi2exc"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@pi2exc"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@pi2exc((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@pi2exc((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge itokens ***

	public interface Iitokens : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @itokens : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Iitokens
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@itokens[] pool = new GRGEN_MODEL.@itokens[10];
		
		// explicit initializations of itokens for target itokens
		// implicit initializations of itokens for target itokens
		static @itokens() {
		}
		
		public @itokens(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_itokens.typeVar, source, target)
		{
			// implicit initialization, map/set creation of itokens
			// explicit initializations of itokens for target itokens
		}

		public static GRGEN_MODEL.EdgeType_itokens TypeInstance { get { return GRGEN_MODEL.EdgeType_itokens.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@itokens(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @itokens(GRGEN_MODEL.@itokens oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_itokens.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@itokens CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@itokens edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@itokens(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of itokens
				// explicit initializations of itokens for target itokens
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@itokens CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@itokens edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@itokens(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of itokens
				// explicit initializations of itokens for target itokens
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"itokens\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"itokens\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of itokens
			// explicit initializations of itokens for target itokens
		}
	}

	public sealed class EdgeType_itokens : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_itokens typeVar = new GRGEN_MODEL.EdgeType_itokens();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_itokens() : base((int) EdgeTypes.@itokens)
		{
		}
		public override string Name { get { return "itokens"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.Iitokens"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@itokens"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@itokens((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@itokens((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge Tokens ***

	public interface ITokens : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @Tokens : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.ITokens
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Tokens[] pool = new GRGEN_MODEL.@Tokens[10];
		
		// explicit initializations of Tokens for target Tokens
		// implicit initializations of Tokens for target Tokens
		static @Tokens() {
		}
		
		public @Tokens(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Tokens.typeVar, source, target)
		{
			// implicit initialization, map/set creation of Tokens
			// explicit initializations of Tokens for target Tokens
		}

		public static GRGEN_MODEL.EdgeType_Tokens TypeInstance { get { return GRGEN_MODEL.EdgeType_Tokens.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Tokens(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Tokens(GRGEN_MODEL.@Tokens oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Tokens.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@Tokens CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Tokens edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Tokens(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Tokens
				// explicit initializations of Tokens for target Tokens
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Tokens CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@Tokens edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Tokens(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Tokens
				// explicit initializations of Tokens for target Tokens
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"Tokens\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"Tokens\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Tokens
			// explicit initializations of Tokens for target Tokens
		}
	}

	public sealed class EdgeType_Tokens : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Tokens typeVar = new GRGEN_MODEL.EdgeType_Tokens();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_Tokens() : base((int) EdgeTypes.@Tokens)
		{
		}
		public override string Name { get { return "Tokens"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ITokens"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Tokens"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Tokens((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Tokens((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge activities ***

	public interface Iactivities : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @activities : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Iactivities
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@activities[] pool = new GRGEN_MODEL.@activities[10];
		
		// explicit initializations of activities for target activities
		// implicit initializations of activities for target activities
		static @activities() {
		}
		
		public @activities(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_activities.typeVar, source, target)
		{
			// implicit initialization, map/set creation of activities
			// explicit initializations of activities for target activities
		}

		public static GRGEN_MODEL.EdgeType_activities TypeInstance { get { return GRGEN_MODEL.EdgeType_activities.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@activities(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @activities(GRGEN_MODEL.@activities oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_activities.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@activities CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@activities edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@activities(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of activities
				// explicit initializations of activities for target activities
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@activities CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@activities edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@activities(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of activities
				// explicit initializations of activities for target activities
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"activities\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"activities\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of activities
			// explicit initializations of activities for target activities
		}
	}

	public sealed class EdgeType_activities : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_activities typeVar = new GRGEN_MODEL.EdgeType_activities();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_activities() : base((int) EdgeTypes.@activities)
		{
		}
		public override string Name { get { return "activities"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.Iactivities"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@activities"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@activities((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@activities((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge sequenceflows ***

	public interface Isequenceflows : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @sequenceflows : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.Isequenceflows
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@sequenceflows[] pool = new GRGEN_MODEL.@sequenceflows[10];
		
		// explicit initializations of sequenceflows for target sequenceflows
		// implicit initializations of sequenceflows for target sequenceflows
		static @sequenceflows() {
		}
		
		public @sequenceflows(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_sequenceflows.typeVar, source, target)
		{
			// implicit initialization, map/set creation of sequenceflows
			// explicit initializations of sequenceflows for target sequenceflows
		}

		public static GRGEN_MODEL.EdgeType_sequenceflows TypeInstance { get { return GRGEN_MODEL.EdgeType_sequenceflows.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@sequenceflows(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @sequenceflows(GRGEN_MODEL.@sequenceflows oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_sequenceflows.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@sequenceflows CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@sequenceflows edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@sequenceflows(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of sequenceflows
				// explicit initializations of sequenceflows for target sequenceflows
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@sequenceflows CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@sequenceflows edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@sequenceflows(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of sequenceflows
				// explicit initializations of sequenceflows for target sequenceflows
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"sequenceflows\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"sequenceflows\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of sequenceflows
			// explicit initializations of sequenceflows for target sequenceflows
		}
	}

	public sealed class EdgeType_sequenceflows : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_sequenceflows typeVar = new GRGEN_MODEL.EdgeType_sequenceflows();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_sequenceflows() : base((int) EdgeTypes.@sequenceflows)
		{
		}
		public override string Name { get { return "sequenceflows"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.Isequenceflows"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@sequenceflows"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@sequenceflows((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@sequenceflows((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge SequenceFlow ***

	public interface ISequenceFlow : GRGEN_LIBGR.IEdge
	{
		GRGEN_MODEL.ENUM_ConditionType @Type { get; set; }
	}

	public sealed class @SequenceFlow : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.ISequenceFlow
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@SequenceFlow[] pool = new GRGEN_MODEL.@SequenceFlow[10];
		
		// explicit initializations of SequenceFlow for target SequenceFlow
		// implicit initializations of SequenceFlow for target SequenceFlow
		static @SequenceFlow() {
		}
		
		public @SequenceFlow(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_SequenceFlow.typeVar, source, target)
		{
			// implicit initialization, map/set creation of SequenceFlow
			// explicit initializations of SequenceFlow for target SequenceFlow
		}

		public static GRGEN_MODEL.EdgeType_SequenceFlow TypeInstance { get { return GRGEN_MODEL.EdgeType_SequenceFlow.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@SequenceFlow(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @SequenceFlow(GRGEN_MODEL.@SequenceFlow oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_SequenceFlow.typeVar, newSource, newTarget)
		{
			Type\u0303 = oldElem.Type\u0303;
		}
		public static GRGEN_MODEL.@SequenceFlow CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@SequenceFlow edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@SequenceFlow(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of SequenceFlow
				edge.@Type = 0;
				// explicit initializations of SequenceFlow for target SequenceFlow
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@SequenceFlow CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@SequenceFlow edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@SequenceFlow(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of SequenceFlow
				edge.@Type = 0;
				// explicit initializations of SequenceFlow for target SequenceFlow
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private GRGEN_MODEL.ENUM_ConditionType Type\u0303;
		public GRGEN_MODEL.ENUM_ConditionType @Type
		{
			get { return Type\u0303; }
			set { Type\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "Type": return this.@Type;
			}
			throw new NullReferenceException(
				"The edge type \"SequenceFlow\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "Type": this.@Type = (GRGEN_MODEL.ENUM_ConditionType) value; return;
			}
			throw new NullReferenceException(
				"The edge type \"SequenceFlow\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of SequenceFlow
			this.@Type = 0;
			// explicit initializations of SequenceFlow for target SequenceFlow
		}
	}

	public sealed class EdgeType_SequenceFlow : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_SequenceFlow typeVar = new GRGEN_MODEL.EdgeType_SequenceFlow();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_Type;
		public EdgeType_SequenceFlow() : base((int) EdgeTypes.@SequenceFlow)
		{
			AttributeType_Type = new GRGEN_LIBGR.AttributeType("Type", this, GRGEN_LIBGR.AttributeKind.EnumAttr, GRGEN_MODEL.Enums.@ConditionType, null, null, null);
		}
		public override string Name { get { return "SequenceFlow"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ISequenceFlow"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@SequenceFlow"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@SequenceFlow((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_Type;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "Type" : return AttributeType_Type;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			GRGEN_LGSP.LGSPEdge oldEdge = (GRGEN_LGSP.LGSPEdge) oldIEdge;
			GRGEN_MODEL.@SequenceFlow newEdge = new GRGEN_MODEL.@SequenceFlow((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
			switch(oldEdge.Type.TypeID)
			{
				case (int) EdgeTypes.@SequenceFlow:
					// copy attributes for: SequenceFlow
					{
						GRGEN_MODEL.ISequenceFlow old = (GRGEN_MODEL.ISequenceFlow) oldEdge;
						newEdge.@Type = old.@Type;
					}
					break;
			}
			return newEdge;
		}

	}

	// *** Edge Tok2Tok ***

	public interface ITok2Tok : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @Tok2Tok : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.ITok2Tok
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Tok2Tok[] pool = new GRGEN_MODEL.@Tok2Tok[10];
		
		// explicit initializations of Tok2Tok for target Tok2Tok
		// implicit initializations of Tok2Tok for target Tok2Tok
		static @Tok2Tok() {
		}
		
		public @Tok2Tok(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Tok2Tok.typeVar, source, target)
		{
			// implicit initialization, map/set creation of Tok2Tok
			// explicit initializations of Tok2Tok for target Tok2Tok
		}

		public static GRGEN_MODEL.EdgeType_Tok2Tok TypeInstance { get { return GRGEN_MODEL.EdgeType_Tok2Tok.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Tok2Tok(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Tok2Tok(GRGEN_MODEL.@Tok2Tok oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Tok2Tok.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@Tok2Tok CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Tok2Tok edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Tok2Tok(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Tok2Tok
				// explicit initializations of Tok2Tok for target Tok2Tok
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Tok2Tok CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@Tok2Tok edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Tok2Tok(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Tok2Tok
				// explicit initializations of Tok2Tok for target Tok2Tok
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"Tok2Tok\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"Tok2Tok\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Tok2Tok
			// explicit initializations of Tok2Tok for target Tok2Tok
		}
	}

	public sealed class EdgeType_Tok2Tok : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Tok2Tok typeVar = new GRGEN_MODEL.EdgeType_Tok2Tok();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_Tok2Tok() : base((int) EdgeTypes.@Tok2Tok)
		{
		}
		public override string Name { get { return "Tok2Tok"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ITok2Tok"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Tok2Tok"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Tok2Tok((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Tok2Tok((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge TokCopyOf ***

	public interface ITokCopyOf : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @TokCopyOf : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.ITokCopyOf
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@TokCopyOf[] pool = new GRGEN_MODEL.@TokCopyOf[10];
		
		// explicit initializations of TokCopyOf for target TokCopyOf
		// implicit initializations of TokCopyOf for target TokCopyOf
		static @TokCopyOf() {
		}
		
		public @TokCopyOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_TokCopyOf.typeVar, source, target)
		{
			// implicit initialization, map/set creation of TokCopyOf
			// explicit initializations of TokCopyOf for target TokCopyOf
		}

		public static GRGEN_MODEL.EdgeType_TokCopyOf TypeInstance { get { return GRGEN_MODEL.EdgeType_TokCopyOf.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@TokCopyOf(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @TokCopyOf(GRGEN_MODEL.@TokCopyOf oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_TokCopyOf.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@TokCopyOf CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@TokCopyOf edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@TokCopyOf(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of TokCopyOf
				// explicit initializations of TokCopyOf for target TokCopyOf
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@TokCopyOf CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@TokCopyOf edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@TokCopyOf(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of TokCopyOf
				// explicit initializations of TokCopyOf for target TokCopyOf
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"TokCopyOf\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"TokCopyOf\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of TokCopyOf
			// explicit initializations of TokCopyOf for target TokCopyOf
		}
	}

	public sealed class EdgeType_TokCopyOf : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_TokCopyOf typeVar = new GRGEN_MODEL.EdgeType_TokCopyOf();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_TokCopyOf() : base((int) EdgeTypes.@TokCopyOf)
		{
		}
		public override string Name { get { return "TokCopyOf"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ITokCopyOf"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@TokCopyOf"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@TokCopyOf((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@TokCopyOf((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge CopiedTo ***

	public interface ICopiedTo : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @CopiedTo : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.ICopiedTo
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@CopiedTo[] pool = new GRGEN_MODEL.@CopiedTo[10];
		
		// explicit initializations of CopiedTo for target CopiedTo
		// implicit initializations of CopiedTo for target CopiedTo
		static @CopiedTo() {
		}
		
		public @CopiedTo(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_CopiedTo.typeVar, source, target)
		{
			// implicit initialization, map/set creation of CopiedTo
			// explicit initializations of CopiedTo for target CopiedTo
		}

		public static GRGEN_MODEL.EdgeType_CopiedTo TypeInstance { get { return GRGEN_MODEL.EdgeType_CopiedTo.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@CopiedTo(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @CopiedTo(GRGEN_MODEL.@CopiedTo oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_CopiedTo.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@CopiedTo CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@CopiedTo edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@CopiedTo(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of CopiedTo
				// explicit initializations of CopiedTo for target CopiedTo
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@CopiedTo CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@CopiedTo edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@CopiedTo(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of CopiedTo
				// explicit initializations of CopiedTo for target CopiedTo
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"CopiedTo\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"CopiedTo\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of CopiedTo
			// explicit initializations of CopiedTo for target CopiedTo
		}
	}

	public sealed class EdgeType_CopiedTo : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_CopiedTo typeVar = new GRGEN_MODEL.EdgeType_CopiedTo();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_CopiedTo() : base((int) EdgeTypes.@CopiedTo)
		{
		}
		public override string Name { get { return "CopiedTo"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ICopiedTo"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@CopiedTo"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@CopiedTo((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@CopiedTo((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge dFlow ***

	public interface IdFlow : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @dFlow : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IdFlow
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@dFlow[] pool = new GRGEN_MODEL.@dFlow[10];
		
		// explicit initializations of dFlow for target dFlow
		// implicit initializations of dFlow for target dFlow
		static @dFlow() {
		}
		
		public @dFlow(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_dFlow.typeVar, source, target)
		{
			// implicit initialization, map/set creation of dFlow
			// explicit initializations of dFlow for target dFlow
		}

		public static GRGEN_MODEL.EdgeType_dFlow TypeInstance { get { return GRGEN_MODEL.EdgeType_dFlow.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@dFlow(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @dFlow(GRGEN_MODEL.@dFlow oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_dFlow.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@dFlow CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@dFlow edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@dFlow(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of dFlow
				// explicit initializations of dFlow for target dFlow
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@dFlow CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@dFlow edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@dFlow(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of dFlow
				// explicit initializations of dFlow for target dFlow
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"dFlow\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"dFlow\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of dFlow
			// explicit initializations of dFlow for target dFlow
		}
	}

	public sealed class EdgeType_dFlow : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_dFlow typeVar = new GRGEN_MODEL.EdgeType_dFlow();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType_dFlow() : base((int) EdgeTypes.@dFlow)
		{
		}
		public override string Name { get { return "dFlow"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IdFlow"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@dFlow"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@dFlow((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@dFlow((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge _From ***

	public interface I_From : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @_From : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.I_From
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@_From[] pool = new GRGEN_MODEL.@_From[10];
		
		// explicit initializations of _From for target _From
		// implicit initializations of _From for target _From
		static @_From() {
		}
		
		public @_From(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType__From.typeVar, source, target)
		{
			// implicit initialization, map/set creation of _From
			// explicit initializations of _From for target _From
		}

		public static GRGEN_MODEL.EdgeType__From TypeInstance { get { return GRGEN_MODEL.EdgeType__From.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@_From(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @_From(GRGEN_MODEL.@_From oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType__From.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@_From CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@_From edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_From(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _From
				// explicit initializations of _From for target _From
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@_From CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@_From edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_From(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _From
				// explicit initializations of _From for target _From
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"_From\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"_From\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of _From
			// explicit initializations of _From for target _From
		}
	}

	public sealed class EdgeType__From : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType__From typeVar = new GRGEN_MODEL.EdgeType__From();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, };
		public EdgeType__From() : base((int) EdgeTypes.@_From)
		{
		}
		public override string Name { get { return "_From"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_From"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@_From"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@_From((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@_From((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge _To ***

	public interface I_To : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @_To : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.I_To
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@_To[] pool = new GRGEN_MODEL.@_To[10];
		
		// explicit initializations of _To for target _To
		// implicit initializations of _To for target _To
		static @_To() {
		}
		
		public @_To(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType__To.typeVar, source, target)
		{
			// implicit initialization, map/set creation of _To
			// explicit initializations of _To for target _To
		}

		public static GRGEN_MODEL.EdgeType__To TypeInstance { get { return GRGEN_MODEL.EdgeType__To.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@_To(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @_To(GRGEN_MODEL.@_To oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType__To.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@_To CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@_To edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_To(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _To
				// explicit initializations of _To for target _To
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@_To CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@_To edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_To(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _To
				// explicit initializations of _To for target _To
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"_To\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"_To\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of _To
			// explicit initializations of _To for target _To
		}
	}

	public sealed class EdgeType__To : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType__To typeVar = new GRGEN_MODEL.EdgeType__To();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, };
		public EdgeType__To() : base((int) EdgeTypes.@_To)
		{
		}
		public override string Name { get { return "_To"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_To"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@_To"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@_To((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@_To((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge Association ***

	public interface IAssociation : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @Association : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IAssociation
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Association[] pool = new GRGEN_MODEL.@Association[10];
		
		// explicit initializations of Association for target Association
		// implicit initializations of Association for target Association
		static @Association() {
		}
		
		public @Association(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Association.typeVar, source, target)
		{
			// implicit initialization, map/set creation of Association
			// explicit initializations of Association for target Association
		}

		public static GRGEN_MODEL.EdgeType_Association TypeInstance { get { return GRGEN_MODEL.EdgeType_Association.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Association(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Association(GRGEN_MODEL.@Association oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Association.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@Association CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Association edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Association(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Association
				// explicit initializations of Association for target Association
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Association CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@Association edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Association(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Association
				// explicit initializations of Association for target Association
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"Association\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"Association\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Association
			// explicit initializations of Association for target Association
		}
	}

	public sealed class EdgeType_Association : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Association typeVar = new GRGEN_MODEL.EdgeType_Association();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, };
		public EdgeType_Association() : base((int) EdgeTypes.@Association)
		{
		}
		public override string Name { get { return "Association"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IAssociation"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Association"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Association((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Association((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge Melem ***

	public interface IMelem : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @Melem : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IMelem
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Melem[] pool = new GRGEN_MODEL.@Melem[10];
		
		// explicit initializations of Melem for target Melem
		// implicit initializations of Melem for target Melem
		static @Melem() {
		}
		
		public @Melem(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Melem.typeVar, source, target)
		{
			// implicit initialization, map/set creation of Melem
			// explicit initializations of Melem for target Melem
		}

		public static GRGEN_MODEL.EdgeType_Melem TypeInstance { get { return GRGEN_MODEL.EdgeType_Melem.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Melem(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Melem(GRGEN_MODEL.@Melem oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Melem.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@Melem CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Melem edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Melem(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Melem
				// explicit initializations of Melem for target Melem
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Melem CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@Melem edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Melem(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Melem
				// explicit initializations of Melem for target Melem
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"Melem\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"Melem\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Melem
			// explicit initializations of Melem for target Melem
		}
	}

	public sealed class EdgeType_Melem : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Melem typeVar = new GRGEN_MODEL.EdgeType_Melem();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, };
		public EdgeType_Melem() : base((int) EdgeTypes.@Melem)
		{
		}
		public override string Name { get { return "Melem"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IMelem"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Melem"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Melem((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Melem((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge Mnext ***

	public interface IMnext : GRGEN_LIBGR.IEdge
	{
		string @ruleName { get; set; }
	}

	public sealed class @Mnext : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IMnext
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Mnext[] pool = new GRGEN_MODEL.@Mnext[10];
		
		// explicit initializations of Mnext for target Mnext
		// implicit initializations of Mnext for target Mnext
		static @Mnext() {
		}
		
		public @Mnext(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Mnext.typeVar, source, target)
		{
			// implicit initialization, map/set creation of Mnext
			// explicit initializations of Mnext for target Mnext
		}

		public static GRGEN_MODEL.EdgeType_Mnext TypeInstance { get { return GRGEN_MODEL.EdgeType_Mnext.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Mnext(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Mnext(GRGEN_MODEL.@Mnext oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Mnext.typeVar, newSource, newTarget)
		{
			ruleName\u0303 = oldElem.ruleName\u0303;
		}
		public static GRGEN_MODEL.@Mnext CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Mnext edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Mnext(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Mnext
				edge.@ruleName = null;
				// explicit initializations of Mnext for target Mnext
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Mnext CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@Mnext edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Mnext(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Mnext
				edge.@ruleName = null;
				// explicit initializations of Mnext for target Mnext
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}


		private string ruleName\u0303;
		public string @ruleName
		{
			get { return ruleName\u0303; }
			set { ruleName\u0303 = value; }
		}
		public override object GetAttribute(string attrName)
		{
			switch(attrName)
			{
				case "ruleName": return this.@ruleName;
			}
			throw new NullReferenceException(
				"The edge type \"Mnext\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			switch(attrName)
			{
				case "ruleName": this.@ruleName = (string) value; return;
			}
			throw new NullReferenceException(
				"The edge type \"Mnext\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Mnext
			this.@ruleName = null;
			// explicit initializations of Mnext for target Mnext
		}
	}

	public sealed class EdgeType_Mnext : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Mnext typeVar = new GRGEN_MODEL.EdgeType_Mnext();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, };
		public static GRGEN_LIBGR.AttributeType AttributeType_ruleName;
		public EdgeType_Mnext() : base((int) EdgeTypes.@Mnext)
		{
			AttributeType_ruleName = new GRGEN_LIBGR.AttributeType("ruleName", this, GRGEN_LIBGR.AttributeKind.StringAttr, null, null, null, null);
		}
		public override string Name { get { return "Mnext"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IMnext"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Mnext"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Mnext((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 1; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes
		{
			get
			{
				yield return AttributeType_ruleName;
			}
		}
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name)
		{
			switch(name)
			{
				case "ruleName" : return AttributeType_ruleName;
			}
			return null;
		}
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			GRGEN_LGSP.LGSPEdge oldEdge = (GRGEN_LGSP.LGSPEdge) oldIEdge;
			GRGEN_MODEL.@Mnext newEdge = new GRGEN_MODEL.@Mnext((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
			switch(oldEdge.Type.TypeID)
			{
				case (int) EdgeTypes.@Mnext:
					// copy attributes for: Mnext
					{
						GRGEN_MODEL.IMnext old = (GRGEN_MODEL.IMnext) oldEdge;
						newEdge.@ruleName = old.@ruleName;
					}
					break;
			}
			return newEdge;
		}

	}

	// *** Edge _FromMarking ***

	public interface I_FromMarking : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @_FromMarking : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.I_FromMarking
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@_FromMarking[] pool = new GRGEN_MODEL.@_FromMarking[10];
		
		// explicit initializations of _FromMarking for target _FromMarking
		// implicit initializations of _FromMarking for target _FromMarking
		static @_FromMarking() {
		}
		
		public @_FromMarking(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType__FromMarking.typeVar, source, target)
		{
			// implicit initialization, map/set creation of _FromMarking
			// explicit initializations of _FromMarking for target _FromMarking
		}

		public static GRGEN_MODEL.EdgeType__FromMarking TypeInstance { get { return GRGEN_MODEL.EdgeType__FromMarking.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@_FromMarking(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @_FromMarking(GRGEN_MODEL.@_FromMarking oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType__FromMarking.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@_FromMarking CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@_FromMarking edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_FromMarking(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _FromMarking
				// explicit initializations of _FromMarking for target _FromMarking
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@_FromMarking CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@_FromMarking edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_FromMarking(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _FromMarking
				// explicit initializations of _FromMarking for target _FromMarking
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"_FromMarking\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"_FromMarking\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of _FromMarking
			// explicit initializations of _FromMarking for target _FromMarking
		}
	}

	public sealed class EdgeType__FromMarking : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType__FromMarking typeVar = new GRGEN_MODEL.EdgeType__FromMarking();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, };
		public EdgeType__FromMarking() : base((int) EdgeTypes.@_FromMarking)
		{
		}
		public override string Name { get { return "_FromMarking"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_FromMarking"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@_FromMarking"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@_FromMarking((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@_FromMarking((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge _ToMarking ***

	public interface I_ToMarking : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @_ToMarking : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.I_ToMarking
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@_ToMarking[] pool = new GRGEN_MODEL.@_ToMarking[10];
		
		// explicit initializations of _ToMarking for target _ToMarking
		// implicit initializations of _ToMarking for target _ToMarking
		static @_ToMarking() {
		}
		
		public @_ToMarking(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType__ToMarking.typeVar, source, target)
		{
			// implicit initialization, map/set creation of _ToMarking
			// explicit initializations of _ToMarking for target _ToMarking
		}

		public static GRGEN_MODEL.EdgeType__ToMarking TypeInstance { get { return GRGEN_MODEL.EdgeType__ToMarking.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@_ToMarking(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @_ToMarking(GRGEN_MODEL.@_ToMarking oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType__ToMarking.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@_ToMarking CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@_ToMarking edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_ToMarking(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _ToMarking
				// explicit initializations of _ToMarking for target _ToMarking
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@_ToMarking CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@_ToMarking edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_ToMarking(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _ToMarking
				// explicit initializations of _ToMarking for target _ToMarking
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"_ToMarking\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"_ToMarking\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of _ToMarking
			// explicit initializations of _ToMarking for target _ToMarking
		}
	}

	public sealed class EdgeType__ToMarking : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType__ToMarking typeVar = new GRGEN_MODEL.EdgeType__ToMarking();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, };
		public EdgeType__ToMarking() : base((int) EdgeTypes.@_ToMarking)
		{
		}
		public override string Name { get { return "_ToMarking"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_ToMarking"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@_ToMarking"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@_ToMarking((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@_ToMarking((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge _Cause ***

	public interface I_Cause : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @_Cause : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.I_Cause
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@_Cause[] pool = new GRGEN_MODEL.@_Cause[10];
		
		// explicit initializations of _Cause for target _Cause
		// implicit initializations of _Cause for target _Cause
		static @_Cause() {
		}
		
		public @_Cause(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType__Cause.typeVar, source, target)
		{
			// implicit initialization, map/set creation of _Cause
			// explicit initializations of _Cause for target _Cause
		}

		public static GRGEN_MODEL.EdgeType__Cause TypeInstance { get { return GRGEN_MODEL.EdgeType__Cause.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@_Cause(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @_Cause(GRGEN_MODEL.@_Cause oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType__Cause.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@_Cause CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@_Cause edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_Cause(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _Cause
				// explicit initializations of _Cause for target _Cause
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@_Cause CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@_Cause edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@_Cause(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of _Cause
				// explicit initializations of _Cause for target _Cause
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"_Cause\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"_Cause\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of _Cause
			// explicit initializations of _Cause for target _Cause
		}
	}

	public sealed class EdgeType__Cause : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType__Cause typeVar = new GRGEN_MODEL.EdgeType__Cause();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, };
		public EdgeType__Cause() : base((int) EdgeTypes.@_Cause)
		{
		}
		public override string Name { get { return "_Cause"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.I_Cause"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@_Cause"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@_Cause((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@_Cause((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge MreplayOf ***

	public interface IMreplayOf : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @MreplayOf : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IMreplayOf
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@MreplayOf[] pool = new GRGEN_MODEL.@MreplayOf[10];
		
		// explicit initializations of MreplayOf for target MreplayOf
		// implicit initializations of MreplayOf for target MreplayOf
		static @MreplayOf() {
		}
		
		public @MreplayOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_MreplayOf.typeVar, source, target)
		{
			// implicit initialization, map/set creation of MreplayOf
			// explicit initializations of MreplayOf for target MreplayOf
		}

		public static GRGEN_MODEL.EdgeType_MreplayOf TypeInstance { get { return GRGEN_MODEL.EdgeType_MreplayOf.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@MreplayOf(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @MreplayOf(GRGEN_MODEL.@MreplayOf oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_MreplayOf.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@MreplayOf CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@MreplayOf edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@MreplayOf(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of MreplayOf
				// explicit initializations of MreplayOf for target MreplayOf
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@MreplayOf CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@MreplayOf edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@MreplayOf(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of MreplayOf
				// explicit initializations of MreplayOf for target MreplayOf
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"MreplayOf\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"MreplayOf\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of MreplayOf
			// explicit initializations of MreplayOf for target MreplayOf
		}
	}

	public sealed class EdgeType_MreplayOf : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_MreplayOf typeVar = new GRGEN_MODEL.EdgeType_MreplayOf();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, };
		public EdgeType_MreplayOf() : base((int) EdgeTypes.@MreplayOf)
		{
		}
		public override string Name { get { return "MreplayOf"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IMreplayOf"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@MreplayOf"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@MreplayOf((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@MreplayOf((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge Target ***

	public interface ITarget : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @Target : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.ITarget
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Target[] pool = new GRGEN_MODEL.@Target[10];
		
		// explicit initializations of Target for target Target
		// implicit initializations of Target for target Target
		static @Target() {
		}
		
		public @Target(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Target.typeVar, source, target)
		{
			// implicit initialization, map/set creation of Target
			// explicit initializations of Target for target Target
		}

		public static GRGEN_MODEL.EdgeType_Target TypeInstance { get { return GRGEN_MODEL.EdgeType_Target.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Target(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Target(GRGEN_MODEL.@Target oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Target.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@Target CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Target edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Target(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Target
				// explicit initializations of Target for target Target
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Target CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@Target edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Target(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Target
				// explicit initializations of Target for target Target
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"Target\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"Target\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Target
			// explicit initializations of Target for target Target
		}
	}

	public sealed class EdgeType_Target : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Target typeVar = new GRGEN_MODEL.EdgeType_Target();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, };
		public EdgeType_Target() : base((int) EdgeTypes.@Target)
		{
		}
		public override string Name { get { return "Target"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.ITarget"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Target"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Target((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Target((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	// *** Edge Contains ***

	public interface IContains : GRGEN_LIBGR.IEdge
	{
	}

	public sealed class @Contains : GRGEN_LGSP.LGSPEdge, GRGEN_MODEL.IContains
	{
		private static int poolLevel = 0;
		private static GRGEN_MODEL.@Contains[] pool = new GRGEN_MODEL.@Contains[10];
		
		// explicit initializations of Contains for target Contains
		// implicit initializations of Contains for target Contains
		static @Contains() {
		}
		
		public @Contains(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
			: base(GRGEN_MODEL.EdgeType_Contains.typeVar, source, target)
		{
			// implicit initialization, map/set creation of Contains
			// explicit initializations of Contains for target Contains
		}

		public static GRGEN_MODEL.EdgeType_Contains TypeInstance { get { return GRGEN_MODEL.EdgeType_Contains.typeVar; } }

		public override GRGEN_LIBGR.IEdge Clone(GRGEN_LIBGR.INode newSource, GRGEN_LIBGR.INode newTarget)
		{ return new GRGEN_MODEL.@Contains(this, (GRGEN_LGSP.LGSPNode) newSource, (GRGEN_LGSP.LGSPNode) newTarget); }

		private @Contains(GRGEN_MODEL.@Contains oldElem, GRGEN_LGSP.LGSPNode newSource, GRGEN_LGSP.LGSPNode newTarget)
			: base(GRGEN_MODEL.EdgeType_Contains.typeVar, newSource, newTarget)
		{
		}
		public static GRGEN_MODEL.@Contains CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			GRGEN_MODEL.@Contains edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Contains(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Contains
				// explicit initializations of Contains for target Contains
			}
			graph.AddEdge(edge);
			return edge;
		}

		public static GRGEN_MODEL.@Contains CreateEdge(GRGEN_LGSP.LGSPGraph graph, GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			GRGEN_MODEL.@Contains edge;
			if(poolLevel == 0)
				edge = new GRGEN_MODEL.@Contains(source, target);
			else
			{
				edge = pool[--poolLevel];
				edge.lgspFlags &= ~(uint) GRGEN_LGSP.LGSPElemFlags.HAS_VARIABLES;
				edge.lgspSource = source;
				edge.lgspTarget = target;
				// implicit initialization, map/set creation of Contains
				// explicit initializations of Contains for target Contains
			}
			graph.AddEdge(edge, varName);
			return edge;
		}

		public override void Recycle()
		{
			if(poolLevel < 10)
				pool[poolLevel++] = this;
		}

		public override object GetAttribute(string attrName)
		{
			throw new NullReferenceException(
				"The edge type \"Contains\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void SetAttribute(string attrName, object value)
		{
			throw new NullReferenceException(
				"The edge type \"Contains\" does not have the attribute \" + attrName + \"\"!");
		}
		public override void ResetAllAttributes()
		{
			// implicit initialization, map/set creation of Contains
			// explicit initializations of Contains for target Contains
		}
	}

	public sealed class EdgeType_Contains : GRGEN_LIBGR.EdgeType
	{
		public static GRGEN_MODEL.EdgeType_Contains typeVar = new GRGEN_MODEL.EdgeType_Contains();
		public static bool[] isA = new bool[] { true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public static bool[] isMyType = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, };
		public EdgeType_Contains() : base((int) EdgeTypes.@Contains)
		{
		}
		public override string Name { get { return "Contains"; } }
		public override string EdgeInterfaceName { get { return "de.unika.ipd.grGen.Model_BPMN.IContains"; } }
		public override string EdgeClassName { get { return "de.unika.ipd.grGen.Model_BPMN.@Contains"; } }
		public override GRGEN_LIBGR.Directedness Directedness { get { return GRGEN_LIBGR.Directedness.Directed; } }
		public override GRGEN_LIBGR.IEdge CreateEdge(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target)
		{
			return new GRGEN_MODEL.@Contains((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}
		public override bool IsAbstract { get { return false; } }
		public override bool IsConst { get { return false; } }
		public override IEnumerable<KeyValuePair<string, string>> Annotations { get { return annotations; } }
		public IDictionary<string, string> annotations = new Dictionary<string, string>();
		public override int NumAttributes { get { return 0; } }
		public override IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { yield break; } }
		public override GRGEN_LIBGR.AttributeType GetAttributeType(string name) { return null; }
		public override bool IsA(GRGEN_LIBGR.GrGenType other)
		{
			return (this == other) || isA[other.TypeID];
		}
		public override GRGEN_LIBGR.IEdge CreateEdgeWithCopyCommons(GRGEN_LIBGR.INode source, GRGEN_LIBGR.INode target, GRGEN_LIBGR.IEdge oldIEdge)
		{
			return new GRGEN_MODEL.@Contains((GRGEN_LGSP.LGSPNode) source, (GRGEN_LGSP.LGSPNode) target);
		}

	}

	//
	// Edge model
	//

	public sealed class BPMNEdgeModel : GRGEN_LIBGR.IEdgeModel
	{
		public BPMNEdgeModel()
		{
			GRGEN_MODEL.EdgeType_AEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_instatespace.typeVar,
				GRGEN_MODEL.EdgeType_parent2subPI.typeVar,
				GRGEN_MODEL.EdgeType_instOf.typeVar,
				GRGEN_MODEL.EdgeType_pi2mark.typeVar,
				GRGEN_MODEL.EdgeType_flowElements.typeVar,
				GRGEN_MODEL.EdgeType_activityRef.typeVar,
				GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar,
				GRGEN_MODEL.EdgeType_tok2pi.typeVar,
				GRGEN_MODEL.EdgeType_pi2exc.typeVar,
				GRGEN_MODEL.EdgeType_itokens.typeVar,
				GRGEN_MODEL.EdgeType_Tokens.typeVar,
				GRGEN_MODEL.EdgeType_activities.typeVar,
				GRGEN_MODEL.EdgeType_sequenceflows.typeVar,
				GRGEN_MODEL.EdgeType_SequenceFlow.typeVar,
				GRGEN_MODEL.EdgeType_Tok2Tok.typeVar,
				GRGEN_MODEL.EdgeType_TokCopyOf.typeVar,
				GRGEN_MODEL.EdgeType_CopiedTo.typeVar,
				GRGEN_MODEL.EdgeType_dFlow.typeVar,
				GRGEN_MODEL.EdgeType__From.typeVar,
				GRGEN_MODEL.EdgeType__To.typeVar,
				GRGEN_MODEL.EdgeType_Association.typeVar,
				GRGEN_MODEL.EdgeType_Melem.typeVar,
				GRGEN_MODEL.EdgeType_Mnext.typeVar,
				GRGEN_MODEL.EdgeType__FromMarking.typeVar,
				GRGEN_MODEL.EdgeType__ToMarking.typeVar,
				GRGEN_MODEL.EdgeType__Cause.typeVar,
				GRGEN_MODEL.EdgeType_MreplayOf.typeVar,
				GRGEN_MODEL.EdgeType_Target.typeVar,
				GRGEN_MODEL.EdgeType_Contains.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_AEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_AEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_instatespace.typeVar,
				GRGEN_MODEL.EdgeType_parent2subPI.typeVar,
				GRGEN_MODEL.EdgeType_instOf.typeVar,
				GRGEN_MODEL.EdgeType_pi2mark.typeVar,
				GRGEN_MODEL.EdgeType_flowElements.typeVar,
				GRGEN_MODEL.EdgeType_activityRef.typeVar,
				GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar,
				GRGEN_MODEL.EdgeType_tok2pi.typeVar,
				GRGEN_MODEL.EdgeType_pi2exc.typeVar,
				GRGEN_MODEL.EdgeType_itokens.typeVar,
				GRGEN_MODEL.EdgeType_Tokens.typeVar,
				GRGEN_MODEL.EdgeType_activities.typeVar,
				GRGEN_MODEL.EdgeType_sequenceflows.typeVar,
				GRGEN_MODEL.EdgeType_SequenceFlow.typeVar,
				GRGEN_MODEL.EdgeType_Tok2Tok.typeVar,
				GRGEN_MODEL.EdgeType_TokCopyOf.typeVar,
				GRGEN_MODEL.EdgeType_CopiedTo.typeVar,
				GRGEN_MODEL.EdgeType_dFlow.typeVar,
				GRGEN_MODEL.EdgeType__From.typeVar,
				GRGEN_MODEL.EdgeType__To.typeVar,
				GRGEN_MODEL.EdgeType_Association.typeVar,
				GRGEN_MODEL.EdgeType_Melem.typeVar,
				GRGEN_MODEL.EdgeType_Mnext.typeVar,
				GRGEN_MODEL.EdgeType__FromMarking.typeVar,
				GRGEN_MODEL.EdgeType__ToMarking.typeVar,
				GRGEN_MODEL.EdgeType__Cause.typeVar,
				GRGEN_MODEL.EdgeType_MreplayOf.typeVar,
				GRGEN_MODEL.EdgeType_Target.typeVar,
				GRGEN_MODEL.EdgeType_Contains.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_instatespace.typeVar,
				GRGEN_MODEL.EdgeType_parent2subPI.typeVar,
				GRGEN_MODEL.EdgeType_instOf.typeVar,
				GRGEN_MODEL.EdgeType_pi2mark.typeVar,
				GRGEN_MODEL.EdgeType_flowElements.typeVar,
				GRGEN_MODEL.EdgeType_activityRef.typeVar,
				GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar,
				GRGEN_MODEL.EdgeType_tok2pi.typeVar,
				GRGEN_MODEL.EdgeType_pi2exc.typeVar,
				GRGEN_MODEL.EdgeType_itokens.typeVar,
				GRGEN_MODEL.EdgeType_Tokens.typeVar,
				GRGEN_MODEL.EdgeType_activities.typeVar,
				GRGEN_MODEL.EdgeType_sequenceflows.typeVar,
				GRGEN_MODEL.EdgeType_SequenceFlow.typeVar,
				GRGEN_MODEL.EdgeType_Tok2Tok.typeVar,
				GRGEN_MODEL.EdgeType_TokCopyOf.typeVar,
				GRGEN_MODEL.EdgeType_CopiedTo.typeVar,
				GRGEN_MODEL.EdgeType_dFlow.typeVar,
				GRGEN_MODEL.EdgeType__From.typeVar,
				GRGEN_MODEL.EdgeType__To.typeVar,
				GRGEN_MODEL.EdgeType_Association.typeVar,
				GRGEN_MODEL.EdgeType_Melem.typeVar,
				GRGEN_MODEL.EdgeType_Mnext.typeVar,
				GRGEN_MODEL.EdgeType__FromMarking.typeVar,
				GRGEN_MODEL.EdgeType__ToMarking.typeVar,
				GRGEN_MODEL.EdgeType__Cause.typeVar,
				GRGEN_MODEL.EdgeType_MreplayOf.typeVar,
				GRGEN_MODEL.EdgeType_Target.typeVar,
				GRGEN_MODEL.EdgeType_Contains.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Edge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Edge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_UEdge.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_UEdge.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_UEdge.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
			};
			GRGEN_MODEL.EdgeType_instatespace.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_instatespace.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_instatespace.typeVar,
			};
			GRGEN_MODEL.EdgeType_instatespace.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_instatespace.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_instatespace.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_instatespace.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_instatespace.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_instatespace.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_instatespace.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_parent2subPI.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_parent2subPI.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_parent2subPI.typeVar,
			};
			GRGEN_MODEL.EdgeType_parent2subPI.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_parent2subPI.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_parent2subPI.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_parent2subPI.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_parent2subPI.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_parent2subPI.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_parent2subPI.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_instOf.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_instOf.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_instOf.typeVar,
			};
			GRGEN_MODEL.EdgeType_instOf.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_instOf.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_instOf.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_instOf.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_instOf.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_instOf.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_instOf.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_pi2mark.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_pi2mark.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_pi2mark.typeVar,
			};
			GRGEN_MODEL.EdgeType_pi2mark.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_pi2mark.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_pi2mark.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_pi2mark.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_pi2mark.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_pi2mark.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_pi2mark.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_flowElements.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_flowElements.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_flowElements.typeVar,
			};
			GRGEN_MODEL.EdgeType_flowElements.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_flowElements.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_flowElements.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_flowElements.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_flowElements.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_flowElements.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_flowElements.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_activityRef.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_activityRef.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_activityRef.typeVar,
			};
			GRGEN_MODEL.EdgeType_activityRef.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_activityRef.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_activityRef.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_activityRef.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_activityRef.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_activityRef.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_activityRef.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar,
			};
			GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_tok2pi.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_tok2pi.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_tok2pi.typeVar,
			};
			GRGEN_MODEL.EdgeType_tok2pi.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_tok2pi.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_tok2pi.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_tok2pi.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_tok2pi.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_tok2pi.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_tok2pi.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_pi2exc.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_pi2exc.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_pi2exc.typeVar,
			};
			GRGEN_MODEL.EdgeType_pi2exc.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_pi2exc.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_pi2exc.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_pi2exc.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_pi2exc.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_pi2exc.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_pi2exc.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_itokens.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_itokens.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_itokens.typeVar,
			};
			GRGEN_MODEL.EdgeType_itokens.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_itokens.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_itokens.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_itokens.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_itokens.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_itokens.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_itokens.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Tokens.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Tokens.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Tokens.typeVar,
			};
			GRGEN_MODEL.EdgeType_Tokens.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Tokens.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Tokens.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Tokens.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Tokens.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Tokens.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Tokens.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_activities.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_activities.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_activities.typeVar,
			};
			GRGEN_MODEL.EdgeType_activities.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_activities.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_activities.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_activities.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_activities.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_activities.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_activities.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_sequenceflows.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_sequenceflows.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_sequenceflows.typeVar,
			};
			GRGEN_MODEL.EdgeType_sequenceflows.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_sequenceflows.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_sequenceflows.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_sequenceflows.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_sequenceflows.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_sequenceflows.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_sequenceflows.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_SequenceFlow.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_SequenceFlow.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_SequenceFlow.typeVar,
			};
			GRGEN_MODEL.EdgeType_SequenceFlow.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_SequenceFlow.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_SequenceFlow.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_SequenceFlow.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_SequenceFlow.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_SequenceFlow.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_SequenceFlow.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Tok2Tok.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Tok2Tok.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Tok2Tok.typeVar,
			};
			GRGEN_MODEL.EdgeType_Tok2Tok.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Tok2Tok.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Tok2Tok.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Tok2Tok.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Tok2Tok.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Tok2Tok.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Tok2Tok.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_TokCopyOf.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_TokCopyOf.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_TokCopyOf.typeVar,
			};
			GRGEN_MODEL.EdgeType_TokCopyOf.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_TokCopyOf.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_TokCopyOf.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_TokCopyOf.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_TokCopyOf.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_TokCopyOf.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_TokCopyOf.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_CopiedTo.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_CopiedTo.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_CopiedTo.typeVar,
			};
			GRGEN_MODEL.EdgeType_CopiedTo.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_CopiedTo.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_CopiedTo.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_CopiedTo.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_CopiedTo.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_CopiedTo.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_CopiedTo.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_dFlow.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_dFlow.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_dFlow.typeVar,
			};
			GRGEN_MODEL.EdgeType_dFlow.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_dFlow.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_dFlow.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_dFlow.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_dFlow.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_dFlow.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_dFlow.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__From.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType__From.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__From.typeVar,
			};
			GRGEN_MODEL.EdgeType__From.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType__From.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType__From.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType__From.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__From.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__From.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType__From.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__To.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType__To.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__To.typeVar,
			};
			GRGEN_MODEL.EdgeType__To.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType__To.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType__To.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType__To.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__To.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__To.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType__To.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Association.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Association.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Association.typeVar,
			};
			GRGEN_MODEL.EdgeType_Association.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Association.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Association.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Association.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Association.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Association.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Association.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Melem.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Melem.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Melem.typeVar,
			};
			GRGEN_MODEL.EdgeType_Melem.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Melem.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Melem.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Melem.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Melem.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Melem.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Melem.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Mnext.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Mnext.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Mnext.typeVar,
			};
			GRGEN_MODEL.EdgeType_Mnext.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Mnext.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Mnext.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Mnext.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Mnext.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Mnext.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Mnext.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__FromMarking.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType__FromMarking.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__FromMarking.typeVar,
			};
			GRGEN_MODEL.EdgeType__FromMarking.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType__FromMarking.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType__FromMarking.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType__FromMarking.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__FromMarking.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__FromMarking.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType__FromMarking.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__ToMarking.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType__ToMarking.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__ToMarking.typeVar,
			};
			GRGEN_MODEL.EdgeType__ToMarking.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType__ToMarking.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType__ToMarking.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType__ToMarking.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__ToMarking.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__ToMarking.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType__ToMarking.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__Cause.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType__Cause.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__Cause.typeVar,
			};
			GRGEN_MODEL.EdgeType__Cause.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType__Cause.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType__Cause.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType__Cause.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType__Cause.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType__Cause.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType__Cause.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_MreplayOf.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_MreplayOf.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_MreplayOf.typeVar,
			};
			GRGEN_MODEL.EdgeType_MreplayOf.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_MreplayOf.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_MreplayOf.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_MreplayOf.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_MreplayOf.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_MreplayOf.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_MreplayOf.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Target.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Target.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Target.typeVar,
			};
			GRGEN_MODEL.EdgeType_Target.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Target.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Target.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Target.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Target.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Target.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Target.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Contains.typeVar.subOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Contains.typeVar.subOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Contains.typeVar,
			};
			GRGEN_MODEL.EdgeType_Contains.typeVar.directSubGrGenTypes = GRGEN_MODEL.EdgeType_Contains.typeVar.directSubTypes = new GRGEN_LIBGR.EdgeType[] {
			};
			GRGEN_MODEL.EdgeType_Contains.typeVar.superOrSameGrGenTypes = GRGEN_MODEL.EdgeType_Contains.typeVar.superOrSameTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Contains.typeVar,
				GRGEN_MODEL.EdgeType_AEdge.typeVar,
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
			GRGEN_MODEL.EdgeType_Contains.typeVar.directSuperGrGenTypes = GRGEN_MODEL.EdgeType_Contains.typeVar.directSuperTypes = new GRGEN_LIBGR.EdgeType[] {
				GRGEN_MODEL.EdgeType_Edge.typeVar,
			};
		}
		public bool IsNodeModel { get { return false; } }
		public GRGEN_LIBGR.EdgeType RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		GRGEN_LIBGR.GrGenType GRGEN_LIBGR.ITypeModel.RootType { get { return GRGEN_MODEL.EdgeType_AEdge.typeVar; } }
		public GRGEN_LIBGR.EdgeType GetType(string name)
		{
			switch(name)
			{
				case "AEdge" : return GRGEN_MODEL.EdgeType_AEdge.typeVar;
				case "Edge" : return GRGEN_MODEL.EdgeType_Edge.typeVar;
				case "UEdge" : return GRGEN_MODEL.EdgeType_UEdge.typeVar;
				case "instatespace" : return GRGEN_MODEL.EdgeType_instatespace.typeVar;
				case "parent2subPI" : return GRGEN_MODEL.EdgeType_parent2subPI.typeVar;
				case "instOf" : return GRGEN_MODEL.EdgeType_instOf.typeVar;
				case "pi2mark" : return GRGEN_MODEL.EdgeType_pi2mark.typeVar;
				case "flowElements" : return GRGEN_MODEL.EdgeType_flowElements.typeVar;
				case "activityRef" : return GRGEN_MODEL.EdgeType_activityRef.typeVar;
				case "loopCharacteristics" : return GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar;
				case "tok2pi" : return GRGEN_MODEL.EdgeType_tok2pi.typeVar;
				case "pi2exc" : return GRGEN_MODEL.EdgeType_pi2exc.typeVar;
				case "itokens" : return GRGEN_MODEL.EdgeType_itokens.typeVar;
				case "Tokens" : return GRGEN_MODEL.EdgeType_Tokens.typeVar;
				case "activities" : return GRGEN_MODEL.EdgeType_activities.typeVar;
				case "sequenceflows" : return GRGEN_MODEL.EdgeType_sequenceflows.typeVar;
				case "SequenceFlow" : return GRGEN_MODEL.EdgeType_SequenceFlow.typeVar;
				case "Tok2Tok" : return GRGEN_MODEL.EdgeType_Tok2Tok.typeVar;
				case "TokCopyOf" : return GRGEN_MODEL.EdgeType_TokCopyOf.typeVar;
				case "CopiedTo" : return GRGEN_MODEL.EdgeType_CopiedTo.typeVar;
				case "dFlow" : return GRGEN_MODEL.EdgeType_dFlow.typeVar;
				case "_From" : return GRGEN_MODEL.EdgeType__From.typeVar;
				case "_To" : return GRGEN_MODEL.EdgeType__To.typeVar;
				case "Association" : return GRGEN_MODEL.EdgeType_Association.typeVar;
				case "Melem" : return GRGEN_MODEL.EdgeType_Melem.typeVar;
				case "Mnext" : return GRGEN_MODEL.EdgeType_Mnext.typeVar;
				case "_FromMarking" : return GRGEN_MODEL.EdgeType__FromMarking.typeVar;
				case "_ToMarking" : return GRGEN_MODEL.EdgeType__ToMarking.typeVar;
				case "_Cause" : return GRGEN_MODEL.EdgeType__Cause.typeVar;
				case "MreplayOf" : return GRGEN_MODEL.EdgeType_MreplayOf.typeVar;
				case "Target" : return GRGEN_MODEL.EdgeType_Target.typeVar;
				case "Contains" : return GRGEN_MODEL.EdgeType_Contains.typeVar;
			}
			return null;
		}
		GRGEN_LIBGR.GrGenType GRGEN_LIBGR.ITypeModel.GetType(string name)
		{
			return GetType(name);
		}
		private GRGEN_LIBGR.EdgeType[] types = {
			GRGEN_MODEL.EdgeType_AEdge.typeVar,
			GRGEN_MODEL.EdgeType_Edge.typeVar,
			GRGEN_MODEL.EdgeType_UEdge.typeVar,
			GRGEN_MODEL.EdgeType_instatespace.typeVar,
			GRGEN_MODEL.EdgeType_parent2subPI.typeVar,
			GRGEN_MODEL.EdgeType_instOf.typeVar,
			GRGEN_MODEL.EdgeType_pi2mark.typeVar,
			GRGEN_MODEL.EdgeType_flowElements.typeVar,
			GRGEN_MODEL.EdgeType_activityRef.typeVar,
			GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar,
			GRGEN_MODEL.EdgeType_tok2pi.typeVar,
			GRGEN_MODEL.EdgeType_pi2exc.typeVar,
			GRGEN_MODEL.EdgeType_itokens.typeVar,
			GRGEN_MODEL.EdgeType_Tokens.typeVar,
			GRGEN_MODEL.EdgeType_activities.typeVar,
			GRGEN_MODEL.EdgeType_sequenceflows.typeVar,
			GRGEN_MODEL.EdgeType_SequenceFlow.typeVar,
			GRGEN_MODEL.EdgeType_Tok2Tok.typeVar,
			GRGEN_MODEL.EdgeType_TokCopyOf.typeVar,
			GRGEN_MODEL.EdgeType_CopiedTo.typeVar,
			GRGEN_MODEL.EdgeType_dFlow.typeVar,
			GRGEN_MODEL.EdgeType__From.typeVar,
			GRGEN_MODEL.EdgeType__To.typeVar,
			GRGEN_MODEL.EdgeType_Association.typeVar,
			GRGEN_MODEL.EdgeType_Melem.typeVar,
			GRGEN_MODEL.EdgeType_Mnext.typeVar,
			GRGEN_MODEL.EdgeType__FromMarking.typeVar,
			GRGEN_MODEL.EdgeType__ToMarking.typeVar,
			GRGEN_MODEL.EdgeType__Cause.typeVar,
			GRGEN_MODEL.EdgeType_MreplayOf.typeVar,
			GRGEN_MODEL.EdgeType_Target.typeVar,
			GRGEN_MODEL.EdgeType_Contains.typeVar,
		};
		public GRGEN_LIBGR.EdgeType[] Types { get { return types; } }
		GRGEN_LIBGR.GrGenType[] GRGEN_LIBGR.ITypeModel.Types { get { return types; } }
		private System.Type[] typeTypes = {
			typeof(GRGEN_MODEL.EdgeType_AEdge),
			typeof(GRGEN_MODEL.EdgeType_Edge),
			typeof(GRGEN_MODEL.EdgeType_UEdge),
			typeof(GRGEN_MODEL.EdgeType_instatespace),
			typeof(GRGEN_MODEL.EdgeType_parent2subPI),
			typeof(GRGEN_MODEL.EdgeType_instOf),
			typeof(GRGEN_MODEL.EdgeType_pi2mark),
			typeof(GRGEN_MODEL.EdgeType_flowElements),
			typeof(GRGEN_MODEL.EdgeType_activityRef),
			typeof(GRGEN_MODEL.EdgeType_loopCharacteristics),
			typeof(GRGEN_MODEL.EdgeType_tok2pi),
			typeof(GRGEN_MODEL.EdgeType_pi2exc),
			typeof(GRGEN_MODEL.EdgeType_itokens),
			typeof(GRGEN_MODEL.EdgeType_Tokens),
			typeof(GRGEN_MODEL.EdgeType_activities),
			typeof(GRGEN_MODEL.EdgeType_sequenceflows),
			typeof(GRGEN_MODEL.EdgeType_SequenceFlow),
			typeof(GRGEN_MODEL.EdgeType_Tok2Tok),
			typeof(GRGEN_MODEL.EdgeType_TokCopyOf),
			typeof(GRGEN_MODEL.EdgeType_CopiedTo),
			typeof(GRGEN_MODEL.EdgeType_dFlow),
			typeof(GRGEN_MODEL.EdgeType__From),
			typeof(GRGEN_MODEL.EdgeType__To),
			typeof(GRGEN_MODEL.EdgeType_Association),
			typeof(GRGEN_MODEL.EdgeType_Melem),
			typeof(GRGEN_MODEL.EdgeType_Mnext),
			typeof(GRGEN_MODEL.EdgeType__FromMarking),
			typeof(GRGEN_MODEL.EdgeType__ToMarking),
			typeof(GRGEN_MODEL.EdgeType__Cause),
			typeof(GRGEN_MODEL.EdgeType_MreplayOf),
			typeof(GRGEN_MODEL.EdgeType_Target),
			typeof(GRGEN_MODEL.EdgeType_Contains),
		};
		public System.Type[] TypeTypes { get { return typeTypes; } }
		private GRGEN_LIBGR.AttributeType[] attributeTypes = {
			GRGEN_MODEL.EdgeType_instatespace.AttributeType_rName,
			GRGEN_MODEL.EdgeType_SequenceFlow.AttributeType_Type,
			GRGEN_MODEL.EdgeType_Mnext.AttributeType_ruleName,
		};
		public IEnumerable<GRGEN_LIBGR.AttributeType> AttributeTypes { get { return attributeTypes; } }
	}

	//
	// IGraphModel implementation
	//
	public sealed class BPMNGraphModel : GRGEN_LIBGR.IGraphModel
	{
		private BPMNNodeModel nodeModel = new BPMNNodeModel();
		private BPMNEdgeModel edgeModel = new BPMNEdgeModel();
		private GRGEN_LIBGR.ValidateInfo[] validateInfos = {
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_instatespace.typeVar, GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar, GRGEN_MODEL.NodeType_BaseElement.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_parent2subPI.typeVar, GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar, GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_instOf.typeVar, GRGEN_MODEL.NodeType_ProcessInstance.typeVar, GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar, 1, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_pi2mark.typeVar, GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, 1, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_flowElements.typeVar, GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar, GRGEN_MODEL.NodeType_FlowElement.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_activityRef.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar, 0, 1, 1, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_tok2pi.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, GRGEN_MODEL.NodeType_ProcessInstance.typeVar, 0, 1, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_pi2exc.typeVar, GRGEN_MODEL.NodeType_ProcessInstance.typeVar, GRGEN_MODEL.NodeType_PException.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_itokens.typeVar, GRGEN_MODEL.NodeType_ProcessInstance.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Tokens.typeVar, GRGEN_MODEL.NodeType_FlowElement.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 1, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_activities.typeVar, GRGEN_MODEL.NodeType_WorkflowProcess.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_sequenceflows.typeVar, GRGEN_MODEL.NodeType_WorkflowProcess.typeVar, GRGEN_MODEL.NodeType__SequenceFlow.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_SequenceFlow.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Tok2Tok.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_TokCopyOf.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_CopiedTo.typeVar, GRGEN_MODEL.NodeType_Node.typeVar, GRGEN_MODEL.NodeType_Node.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_dFlow.typeVar, GRGEN_MODEL.NodeType__SequenceFlow.typeVar, GRGEN_MODEL.NodeType_dMarker.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__From.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType__Flow.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__To.typeVar, GRGEN_MODEL.NodeType__Flow.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Association.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 1, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Melem.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 1, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Mnext.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__FromMarking.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, GRGEN_MODEL.NodeType_MnextWithCause.typeVar, 0, 2147483647, 1, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__ToMarking.typeVar, GRGEN_MODEL.NodeType_MnextWithCause.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, 1, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__Cause.typeVar, GRGEN_MODEL.NodeType_MnextWithCause.typeVar, GRGEN_MODEL.NodeType_BaseElement.typeVar, 1, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_MreplayOf.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, 0, 1, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Target.typeVar, GRGEN_MODEL.NodeType_IntermediateEvent.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 1, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Contains.typeVar, GRGEN_MODEL.NodeType_ActivitySet.typeVar, GRGEN_MODEL.NodeType_FlowElement.typeVar, 0, 2147483647, 0, 1, false),
		};
		private GRGEN_LIBGR.EnumAttributeType[] enumAttributeTypes = {
			GRGEN_MODEL.Enums.@PIstate,
			GRGEN_MODEL.Enums.@TriggerType,
			GRGEN_MODEL.Enums.@GatewayType,
			GRGEN_MODEL.Enums.@ExclusiveType,
			GRGEN_MODEL.Enums.@ConditionType,
			GRGEN_MODEL.Enums.@SimulatorState,
		};

		public string ModelName { get { return "BPMN"; } }
		public GRGEN_LIBGR.INodeModel NodeModel { get { return nodeModel; } }
		public GRGEN_LIBGR.IEdgeModel EdgeModel { get { return edgeModel; } }
		public IEnumerable<GRGEN_LIBGR.ValidateInfo> ValidateInfo { get { return validateInfos; } }
		public IEnumerable<GRGEN_LIBGR.EnumAttributeType> EnumAttributeTypes { get { return enumAttributeTypes; } }
		public string MD5Hash { get { return "d2db0a2db3a4db9daef99a01fff0d56e"; } }
	}

	//
	// IGraph/IGraphModel implementation
	//
	public class BPMNGraph : GRGEN_LGSP.LGSPGraph, GRGEN_LIBGR.IGraphModel
	{
		public BPMNGraph() : base(GetNextGraphName())
		{
			InitializeGraph(this);
		}

		public GRGEN_MODEL.@Node CreateNodeNode()
		{
			return GRGEN_MODEL.@Node.CreateNode(this);
		}

		public GRGEN_MODEL.@Node CreateNodeNode(string varName)
		{
			return GRGEN_MODEL.@Node.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@WorkflowProcess CreateNodeWorkflowProcess()
		{
			return GRGEN_MODEL.@WorkflowProcess.CreateNode(this);
		}

		public GRGEN_MODEL.@WorkflowProcess CreateNodeWorkflowProcess(string varName)
		{
			return GRGEN_MODEL.@WorkflowProcess.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@AbstrProcessInstance CreateNodeAbstrProcessInstance()
		{
			return GRGEN_MODEL.@AbstrProcessInstance.CreateNode(this);
		}

		public GRGEN_MODEL.@AbstrProcessInstance CreateNodeAbstrProcessInstance(string varName)
		{
			return GRGEN_MODEL.@AbstrProcessInstance.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@ProcessInstance CreateNodeProcessInstance()
		{
			return GRGEN_MODEL.@ProcessInstance.CreateNode(this);
		}

		public GRGEN_MODEL.@ProcessInstance CreateNodeProcessInstance(string varName)
		{
			return GRGEN_MODEL.@ProcessInstance.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@VisibleProcessInstance CreateNodeVisibleProcessInstance()
		{
			return GRGEN_MODEL.@VisibleProcessInstance.CreateNode(this);
		}

		public GRGEN_MODEL.@VisibleProcessInstance CreateNodeVisibleProcessInstance(string varName)
		{
			return GRGEN_MODEL.@VisibleProcessInstance.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@Activity CreateNodeActivity()
		{
			return GRGEN_MODEL.@Activity.CreateNode(this);
		}

		public GRGEN_MODEL.@Activity CreateNodeActivity(string varName)
		{
			return GRGEN_MODEL.@Activity.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@StandardLoopCharacteristics CreateNodeStandardLoopCharacteristics()
		{
			return GRGEN_MODEL.@StandardLoopCharacteristics.CreateNode(this);
		}

		public GRGEN_MODEL.@StandardLoopCharacteristics CreateNodeStandardLoopCharacteristics(string varName)
		{
			return GRGEN_MODEL.@StandardLoopCharacteristics.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@MultipleInstanceLoopCharacteristics CreateNodeMultipleInstanceLoopCharacteristics()
		{
			return GRGEN_MODEL.@MultipleInstanceLoopCharacteristics.CreateNode(this);
		}

		public GRGEN_MODEL.@MultipleInstanceLoopCharacteristics CreateNodeMultipleInstanceLoopCharacteristics(string varName)
		{
			return GRGEN_MODEL.@MultipleInstanceLoopCharacteristics.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@AbstrToken CreateNodeAbstrToken()
		{
			return GRGEN_MODEL.@AbstrToken.CreateNode(this);
		}

		public GRGEN_MODEL.@AbstrToken CreateNodeAbstrToken(string varName)
		{
			return GRGEN_MODEL.@AbstrToken.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@Token CreateNodeToken()
		{
			return GRGEN_MODEL.@Token.CreateNode(this);
		}

		public GRGEN_MODEL.@Token CreateNodeToken(string varName)
		{
			return GRGEN_MODEL.@Token.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@HiddenToken CreateNodeHiddenToken()
		{
			return GRGEN_MODEL.@HiddenToken.CreateNode(this);
		}

		public GRGEN_MODEL.@HiddenToken CreateNodeHiddenToken(string varName)
		{
			return GRGEN_MODEL.@HiddenToken.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@HiddenHistoryToken CreateNodeHiddenHistoryToken()
		{
			return GRGEN_MODEL.@HiddenHistoryToken.CreateNode(this);
		}

		public GRGEN_MODEL.@HiddenHistoryToken CreateNodeHiddenHistoryToken(string varName)
		{
			return GRGEN_MODEL.@HiddenHistoryToken.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@HiddenUndoToken CreateNodeHiddenUndoToken()
		{
			return GRGEN_MODEL.@HiddenUndoToken.CreateNode(this);
		}

		public GRGEN_MODEL.@HiddenUndoToken CreateNodeHiddenUndoToken(string varName)
		{
			return GRGEN_MODEL.@HiddenUndoToken.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@HiddenUndoneToken CreateNodeHiddenUndoneToken()
		{
			return GRGEN_MODEL.@HiddenUndoneToken.CreateNode(this);
		}

		public GRGEN_MODEL.@HiddenUndoneToken CreateNodeHiddenUndoneToken(string varName)
		{
			return GRGEN_MODEL.@HiddenUndoneToken.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@HistoryToken CreateNodeHistoryToken()
		{
			return GRGEN_MODEL.@HistoryToken.CreateNode(this);
		}

		public GRGEN_MODEL.@HistoryToken CreateNodeHistoryToken(string varName)
		{
			return GRGEN_MODEL.@HistoryToken.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@UndoToken CreateNodeUndoToken()
		{
			return GRGEN_MODEL.@UndoToken.CreateNode(this);
		}

		public GRGEN_MODEL.@UndoToken CreateNodeUndoToken(string varName)
		{
			return GRGEN_MODEL.@UndoToken.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@UndoneToken CreateNodeUndoneToken()
		{
			return GRGEN_MODEL.@UndoneToken.CreateNode(this);
		}

		public GRGEN_MODEL.@UndoneToken CreateNodeUndoneToken(string varName)
		{
			return GRGEN_MODEL.@UndoneToken.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@PException CreateNodePException()
		{
			return GRGEN_MODEL.@PException.CreateNode(this);
		}

		public GRGEN_MODEL.@PException CreateNodePException(string varName)
		{
			return GRGEN_MODEL.@PException.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@Task CreateNodeTask()
		{
			return GRGEN_MODEL.@Task.CreateNode(this);
		}

		public GRGEN_MODEL.@Task CreateNodeTask(string varName)
		{
			return GRGEN_MODEL.@Task.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@Event CreateNodeEvent()
		{
			return GRGEN_MODEL.@Event.CreateNode(this);
		}

		public GRGEN_MODEL.@Event CreateNodeEvent(string varName)
		{
			return GRGEN_MODEL.@Event.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@BlockActivity CreateNodeBlockActivity()
		{
			return GRGEN_MODEL.@BlockActivity.CreateNode(this);
		}

		public GRGEN_MODEL.@BlockActivity CreateNodeBlockActivity(string varName)
		{
			return GRGEN_MODEL.@BlockActivity.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@ActivitySet CreateNodeActivitySet()
		{
			return GRGEN_MODEL.@ActivitySet.CreateNode(this);
		}

		public GRGEN_MODEL.@ActivitySet CreateNodeActivitySet(string varName)
		{
			return GRGEN_MODEL.@ActivitySet.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@StartEvent CreateNodeStartEvent()
		{
			return GRGEN_MODEL.@StartEvent.CreateNode(this);
		}

		public GRGEN_MODEL.@StartEvent CreateNodeStartEvent(string varName)
		{
			return GRGEN_MODEL.@StartEvent.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@EndEvent CreateNodeEndEvent()
		{
			return GRGEN_MODEL.@EndEvent.CreateNode(this);
		}

		public GRGEN_MODEL.@EndEvent CreateNodeEndEvent(string varName)
		{
			return GRGEN_MODEL.@EndEvent.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@IntermediateEvent CreateNodeIntermediateEvent()
		{
			return GRGEN_MODEL.@IntermediateEvent.CreateNode(this);
		}

		public GRGEN_MODEL.@IntermediateEvent CreateNodeIntermediateEvent(string varName)
		{
			return GRGEN_MODEL.@IntermediateEvent.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@IntermediateCatchEvent CreateNodeIntermediateCatchEvent()
		{
			return GRGEN_MODEL.@IntermediateCatchEvent.CreateNode(this);
		}

		public GRGEN_MODEL.@IntermediateCatchEvent CreateNodeIntermediateCatchEvent(string varName)
		{
			return GRGEN_MODEL.@IntermediateCatchEvent.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@IntermediateThrowEvent CreateNodeIntermediateThrowEvent()
		{
			return GRGEN_MODEL.@IntermediateThrowEvent.CreateNode(this);
		}

		public GRGEN_MODEL.@IntermediateThrowEvent CreateNodeIntermediateThrowEvent(string varName)
		{
			return GRGEN_MODEL.@IntermediateThrowEvent.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@Gateway CreateNodeGateway()
		{
			return GRGEN_MODEL.@Gateway.CreateNode(this);
		}

		public GRGEN_MODEL.@Gateway CreateNodeGateway(string varName)
		{
			return GRGEN_MODEL.@Gateway.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@_SequenceFlow CreateNode_SequenceFlow()
		{
			return GRGEN_MODEL.@_SequenceFlow.CreateNode(this);
		}

		public GRGEN_MODEL.@_SequenceFlow CreateNode_SequenceFlow(string varName)
		{
			return GRGEN_MODEL.@_SequenceFlow.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@_MessageFlow CreateNode_MessageFlow()
		{
			return GRGEN_MODEL.@_MessageFlow.CreateNode(this);
		}

		public GRGEN_MODEL.@_MessageFlow CreateNode_MessageFlow(string varName)
		{
			return GRGEN_MODEL.@_MessageFlow.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@dMarker CreateNodedMarker()
		{
			return GRGEN_MODEL.@dMarker.CreateNode(this);
		}

		public GRGEN_MODEL.@dMarker CreateNodedMarker(string varName)
		{
			return GRGEN_MODEL.@dMarker.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@_Association CreateNode_Association()
		{
			return GRGEN_MODEL.@_Association.CreateNode(this);
		}

		public GRGEN_MODEL.@_Association CreateNode_Association(string varName)
		{
			return GRGEN_MODEL.@_Association.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@Marking CreateNodeMarking()
		{
			return GRGEN_MODEL.@Marking.CreateNode(this);
		}

		public GRGEN_MODEL.@Marking CreateNodeMarking(string varName)
		{
			return GRGEN_MODEL.@Marking.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@HighlightMarking CreateNodeHighlightMarking()
		{
			return GRGEN_MODEL.@HighlightMarking.CreateNode(this);
		}

		public GRGEN_MODEL.@HighlightMarking CreateNodeHighlightMarking(string varName)
		{
			return GRGEN_MODEL.@HighlightMarking.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@MarkingFromLog CreateNodeMarkingFromLog()
		{
			return GRGEN_MODEL.@MarkingFromLog.CreateNode(this);
		}

		public GRGEN_MODEL.@MarkingFromLog CreateNodeMarkingFromLog(string varName)
		{
			return GRGEN_MODEL.@MarkingFromLog.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@MnextWithCause CreateNodeMnextWithCause()
		{
			return GRGEN_MODEL.@MnextWithCause.CreateNode(this);
		}

		public GRGEN_MODEL.@MnextWithCause CreateNodeMnextWithCause(string varName)
		{
			return GRGEN_MODEL.@MnextWithCause.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@DummyInt CreateNodeDummyInt()
		{
			return GRGEN_MODEL.@DummyInt.CreateNode(this);
		}

		public GRGEN_MODEL.@DummyInt CreateNodeDummyInt(string varName)
		{
			return GRGEN_MODEL.@DummyInt.CreateNode(this, varName);
		}

		public GRGEN_MODEL.@SimulatorSettings CreateNodeSimulatorSettings()
		{
			return GRGEN_MODEL.@SimulatorSettings.CreateNode(this);
		}

		public GRGEN_MODEL.@SimulatorSettings CreateNodeSimulatorSettings(string varName)
		{
			return GRGEN_MODEL.@SimulatorSettings.CreateNode(this, varName);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Edge CreateEdgeEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@Edge.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@UEdge CreateEdgeUEdge(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@UEdge.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@instatespace CreateEdgeinstatespace(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@instatespace.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@instatespace CreateEdgeinstatespace(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@instatespace.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@parent2subPI CreateEdgeparent2subPI(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@parent2subPI.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@parent2subPI CreateEdgeparent2subPI(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@parent2subPI.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@instOf CreateEdgeinstOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@instOf.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@instOf CreateEdgeinstOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@instOf.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@pi2mark CreateEdgepi2mark(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@pi2mark.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@pi2mark CreateEdgepi2mark(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@pi2mark.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@flowElements CreateEdgeflowElements(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@flowElements.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@flowElements CreateEdgeflowElements(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@flowElements.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@activityRef CreateEdgeactivityRef(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@activityRef.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@activityRef CreateEdgeactivityRef(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@activityRef.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@loopCharacteristics CreateEdgeloopCharacteristics(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@loopCharacteristics.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@loopCharacteristics CreateEdgeloopCharacteristics(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@loopCharacteristics.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@tok2pi CreateEdgetok2pi(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@tok2pi.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@tok2pi CreateEdgetok2pi(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@tok2pi.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@pi2exc CreateEdgepi2exc(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@pi2exc.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@pi2exc CreateEdgepi2exc(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@pi2exc.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@itokens CreateEdgeitokens(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@itokens.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@itokens CreateEdgeitokens(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@itokens.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@Tokens CreateEdgeTokens(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Tokens.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Tokens CreateEdgeTokens(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@Tokens.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@activities CreateEdgeactivities(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@activities.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@activities CreateEdgeactivities(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@activities.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@sequenceflows CreateEdgesequenceflows(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@sequenceflows.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@sequenceflows CreateEdgesequenceflows(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@sequenceflows.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@SequenceFlow CreateEdgeSequenceFlow(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@SequenceFlow.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@SequenceFlow CreateEdgeSequenceFlow(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@SequenceFlow.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@Tok2Tok CreateEdgeTok2Tok(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Tok2Tok.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Tok2Tok CreateEdgeTok2Tok(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@Tok2Tok.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@TokCopyOf CreateEdgeTokCopyOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@TokCopyOf.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@TokCopyOf CreateEdgeTokCopyOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@TokCopyOf.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@CopiedTo CreateEdgeCopiedTo(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@CopiedTo.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@CopiedTo CreateEdgeCopiedTo(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@CopiedTo.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@dFlow CreateEdgedFlow(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@dFlow.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@dFlow CreateEdgedFlow(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@dFlow.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@_From CreateEdge_From(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@_From.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@_From CreateEdge_From(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@_From.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@_To CreateEdge_To(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@_To.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@_To CreateEdge_To(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@_To.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@Association CreateEdgeAssociation(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Association.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Association CreateEdgeAssociation(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@Association.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@Melem CreateEdgeMelem(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Melem.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Melem CreateEdgeMelem(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@Melem.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@Mnext CreateEdgeMnext(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Mnext.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Mnext CreateEdgeMnext(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@Mnext.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@_FromMarking CreateEdge_FromMarking(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@_FromMarking.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@_FromMarking CreateEdge_FromMarking(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@_FromMarking.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@_ToMarking CreateEdge_ToMarking(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@_ToMarking.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@_ToMarking CreateEdge_ToMarking(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@_ToMarking.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@_Cause CreateEdge_Cause(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@_Cause.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@_Cause CreateEdge_Cause(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@_Cause.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@MreplayOf CreateEdgeMreplayOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@MreplayOf.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@MreplayOf CreateEdgeMreplayOf(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@MreplayOf.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@Target CreateEdgeTarget(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Target.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Target CreateEdgeTarget(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@Target.CreateEdge(this, source, target, varName);
		}

		public @GRGEN_MODEL.@Contains CreateEdgeContains(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target)
		{
			return @GRGEN_MODEL.@Contains.CreateEdge(this, source, target);
		}

		public @GRGEN_MODEL.@Contains CreateEdgeContains(GRGEN_LGSP.LGSPNode source, GRGEN_LGSP.LGSPNode target, string varName)
		{
			return @GRGEN_MODEL.@Contains.CreateEdge(this, source, target, varName);
		}

		private BPMNNodeModel nodeModel = new BPMNNodeModel();
		private BPMNEdgeModel edgeModel = new BPMNEdgeModel();
		private GRGEN_LIBGR.ValidateInfo[] validateInfos = {
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_instatespace.typeVar, GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar, GRGEN_MODEL.NodeType_BaseElement.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_parent2subPI.typeVar, GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar, GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_instOf.typeVar, GRGEN_MODEL.NodeType_ProcessInstance.typeVar, GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar, 1, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_pi2mark.typeVar, GRGEN_MODEL.NodeType_AbstrProcessInstance.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, 1, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_flowElements.typeVar, GRGEN_MODEL.NodeType_FlowElementsContainer.typeVar, GRGEN_MODEL.NodeType_FlowElement.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_activityRef.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_loopCharacteristics.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType_LoopCharacteristics.typeVar, 0, 1, 1, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_tok2pi.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, GRGEN_MODEL.NodeType_ProcessInstance.typeVar, 0, 1, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_pi2exc.typeVar, GRGEN_MODEL.NodeType_ProcessInstance.typeVar, GRGEN_MODEL.NodeType_PException.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_itokens.typeVar, GRGEN_MODEL.NodeType_ProcessInstance.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Tokens.typeVar, GRGEN_MODEL.NodeType_FlowElement.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 1, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_activities.typeVar, GRGEN_MODEL.NodeType_WorkflowProcess.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_sequenceflows.typeVar, GRGEN_MODEL.NodeType_WorkflowProcess.typeVar, GRGEN_MODEL.NodeType__SequenceFlow.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_SequenceFlow.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Tok2Tok.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_TokCopyOf.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_CopiedTo.typeVar, GRGEN_MODEL.NodeType_Node.typeVar, GRGEN_MODEL.NodeType_Node.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_dFlow.typeVar, GRGEN_MODEL.NodeType__SequenceFlow.typeVar, GRGEN_MODEL.NodeType_dMarker.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__From.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType__Flow.typeVar, 0, 2147483647, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__To.typeVar, GRGEN_MODEL.NodeType__Flow.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Association.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 1, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Melem.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, GRGEN_MODEL.NodeType_AbstrToken.typeVar, 0, 2147483647, 1, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Mnext.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, 0, 2147483647, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__FromMarking.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, GRGEN_MODEL.NodeType_MnextWithCause.typeVar, 0, 2147483647, 1, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__ToMarking.typeVar, GRGEN_MODEL.NodeType_MnextWithCause.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, 1, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType__Cause.typeVar, GRGEN_MODEL.NodeType_MnextWithCause.typeVar, GRGEN_MODEL.NodeType_BaseElement.typeVar, 1, 1, 0, 2147483647, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_MreplayOf.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, GRGEN_MODEL.NodeType_Marking.typeVar, 0, 1, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Target.typeVar, GRGEN_MODEL.NodeType_IntermediateEvent.typeVar, GRGEN_MODEL.NodeType_Activity.typeVar, 0, 1, 0, 1, false),
			new GRGEN_LIBGR.ValidateInfo(GRGEN_MODEL.EdgeType_Contains.typeVar, GRGEN_MODEL.NodeType_ActivitySet.typeVar, GRGEN_MODEL.NodeType_FlowElement.typeVar, 0, 2147483647, 0, 1, false),
		};
		private GRGEN_LIBGR.EnumAttributeType[] enumAttributeTypes = {
			GRGEN_MODEL.Enums.@PIstate,
			GRGEN_MODEL.Enums.@TriggerType,
			GRGEN_MODEL.Enums.@GatewayType,
			GRGEN_MODEL.Enums.@ExclusiveType,
			GRGEN_MODEL.Enums.@ConditionType,
			GRGEN_MODEL.Enums.@SimulatorState,
		};

		public string ModelName { get { return "BPMN"; } }
		public GRGEN_LIBGR.INodeModel NodeModel { get { return nodeModel; } }
		public GRGEN_LIBGR.IEdgeModel EdgeModel { get { return edgeModel; } }
		public IEnumerable<GRGEN_LIBGR.ValidateInfo> ValidateInfo { get { return validateInfos; } }
		public IEnumerable<GRGEN_LIBGR.EnumAttributeType> EnumAttributeTypes { get { return enumAttributeTypes; } }
		public string MD5Hash { get { return "d2db0a2db3a4db9daef99a01fff0d56e"; } }
	}
}
