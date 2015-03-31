using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPMNExecutionAndComplianceCheck
{
    public class Element
    {
        public string ID;
        public TypeOfElement Type;
        public string Name;
        public string State;
    }
    public class StruMarking
    {
        public string ID;
        public Element Elment = new Element();
        public List<string> PreMarkingIDlist = new List<string>();
        public List<string> NextMarkingIDlist = new List<string>();
        public int Loop;
        public int Layer;
    }
    public class AMatch
    {
        public int ID;
        public List<AMatch> PreMatch = new List<AMatch>();
        public double Cost;
        public int Deviations;
        public TypeOfMatch MatchType;
        public ActionNode TaskMarking = new ActionNode();
        public AuditTrailEntry Entry=new AuditTrailEntry();
        public int Layer;
    }
    public enum TypeOfMatch
    {
        NotMatched,
        BothCorrect,
        FTaskCEntry,
        CTaskFEntry,
        BothFake
    }
    public enum TypeOfElement
    {
        Empty,
        StartEvent,
        Task,
        GateWay,
        EndEvent,
        Sequence,
        LoopTask,
        BlockActivity,
        IntermediateThrowEvent,
        IntermediateCatchEvent
    }
    public enum TypeOfRuleName
    {
        enterAutonomousStartEvent,
        leaveStartEvent,
        leaveTaskOneOut,
        enterParallelGateway,
        leaveParallelGateway,
        enterEndEvent,
        enterExclusiveGateway,
        leaveDataExclusiveGateway,
        enterSubprocess,
        terminateProcessNormal,
        leaveSubprocessNormal,
        leaveProcessNormal,
        enterInclusiveGateway,
        leaveInclusiveGateway,
        leaveTerminateEndEvent,
        enterThrowErrorEvent,
        leaveThrowErrorEvent,
        enterSignalCatchIntermediateEvent,
        leaveSignalOrMessageOrCancelCatchIntermediateEvent,
        enterSignalOrMessageThrowIntermediateEvent,
        leaveSignalThrowEvent,
        reEnterLoopSubprocess,
        reEnterLoopActivity,
        enterCompensationThrowIntermediateEvent,
        leaveCompensationThrowIntermediateEvent,
        enterAutonomousBoundaryEvent,
        leaveTaskMoreOut,
        leaveImplicitInclORsplit,
        traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions,
        UndoProcessInstance,
        enterCompensationEndEvent,
        skipLoopActivity,
        leaveMessageSendEvent,
        enterMessageCatchIntermediateEvent,
        enterMessageStartEvent,
        enterSignalStartEvent
    }
    public class StartEvent
    {
        public string ID;
        public string Name;
    }
    public class EndEvent
    {
        public string ID;
        public string Name;
    }
    public class IntermediateCatchEvent
    {
        public string ID;
        public string Name;
    }
    public class IntermediateThrowEvent
    {
        public string ID;
        public string Name;
    }
    public class Task
    {
        public string ID;
        public string Name;
    }
    public class BlockActivity
    {
        public string ID;
        public string Name;
    }
    public class Gateway
    {
        public string ID;
        public string Type;
    }
    public class Seque
    {
        public string ID;
    }
    public class ProcIn
    {
        public string ID;
        public string State;
    }
    public class MnextWithCause
    {
        public string ID;
        //public TypeOfRuleName ruleName;
        public string ruleName;
        public string OrgMarkingID;
        public string TargMarkingID;
        public string CauseActivityName;//To indicate the name of the cause
        public string CauseNodeID;//To indicate the different ID even for one activity
    }
    public class ActionNode
    {
        public string ID;
        public Element Elment = new Element();
        public List<string> PreMarkingIDlist = new List<string>();
        public List<string> NextMarkingIDlist = new List<string>();
        public int Loop;
        public int Layer;
    }
    public class Model
    {
        public List<StartEvent> listStartE = new List<StartEvent>();
        public List<EndEvent> listEndE = new List<EndEvent>();
        public List<Task> listTask;
        public List<Gateway> listGateway;
    }
    public class Mnext
    {
        public String OrgID;
        public String TargId;
    }
    public class Melem
    {
        public String MarkID;
        public string TokenID;
    }
    public class Pi2Mark
    {
        public String ProID;
        public string MarkID;
    }
    public class Token
    {
        public string ID;
    }
    public class EdgeTokens
    {
        public string ContainerID;
        public string TokenID;
    }
    public class EdgeFromMark
    {
        public String OrgID;
        public String TargId;
    }
    public class EdgeToMark
    {
        public String OrgID;
        public String TargId;
    }
    public class LoopCharacteristcs
    {
        public string TaskID;
        public string LoopCharEntityID;
    }
    public class AuditTrailEntry
    {
        public String State;
        public string Name;
        public string ID;
    }
    public class HMarking
    {
        public string ID;
        public List<Element> ElmentList = new List<Element>();
        public List<string> PreMarkingIDlist = new List<string>();
        public List<string> NextMarkingIDlist = new List<string>();
        public string ProcessInState;
        public string PreRuleNames;
    }
    public class MarkingShow
    {
        public string ID;
        public List<Element> ElmentList = new List<Element>();
        public List<string> PreMarkingIDlist = new List<string>();
        public List<string> NextMarkingIDlist = new List<string>();
        public string ProcessInState;
        public string PreRuleNames;
    }
    public class CauseNode
    {
        public string ID;
        public Element ActivityEle = new Element();
        public string MnextCauseID;
        public List<string> PreCauselist = new List<string>();
        public List<string> NextCauselist = new List<string>();
        public string ruleName;
    }
    public class Event
    {
        public string Name;
        public string Type;
    }
    public class Node
    {
        public String ID;
        public String Type;
        public String Description;
        public List<string> Ancestors = new List<string>();
        public List<string> Descendants = new List<string>();
        public double WidthOfNode;
        public int HeightOfNode;//含有的纵向节点的个数（包括它自己）
        public double curChilPos;
        public double POSITION;
        public bool HIDE;
        public int Layer;
    }
}
