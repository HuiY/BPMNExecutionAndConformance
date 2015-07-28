using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Data;
using de.unika.ipd.grGen.lgsp;
using de.unika.ipd.grGen.libGr;
using de.unika.ipd.grGen.Action_BPMNV7;
using de.unika.ipd.grGen.Model_BPMN;
using GRGEN_LIBGR = de.unika.ipd.grGen.libGr;
using GRGEN_LGSP = de.unika.ipd.grGen.lgsp;
using GRGEN_EXPR = de.unika.ipd.grGen.expression;
using GRGEN_MODEL = de.unika.ipd.grGen.Model_BPMN;

namespace BPMNExecutionAndComplianceCheck
{
    partial class Form1
    {
        private double dynamicParameter = 0;
        List<List<AuditTrailEntry>> listTraces;
        private string LoadAndRunBPMNFile(string fileDirectory)
        {
            LGSPBackend backend = new LGSPBackend();
            BPMNGraphModel model = new BPMNGraphModel();
           
            NamedGraph importedNamedGraph = (NamedGraph)Porter.Import(fileDirectory, backend, model);
            LGSPGraph graph = (LGSPGraph)(importedNamedGraph.WrappedGraph);
            importedNamedGraph = null;

            BPMNV7Actions actions = new BPMNV7Actions(graph);

            actions.ApplyGraphRewriteSequence(@"visID1 = valloc() && set_nOut && vfree(visID1)");
            actions.ApplyGraphRewriteSequence(@"[mapTo_SequenceFlows] | [mapBack_SequenceFlows] | addActivitiesToWorkflowProcessWhereNeeded | [map_To_FlowElementsContainer] | [addSequenceFlowToContainerOfFromActivity] | [mapTo_Associations]");

            Marking InitMarking = Marking.CreateNode(graph, "InitialMarking");

            IMarking mNewMarking;
            IMarking curMarking1 = new Marking();

            List<Marking> unFinishedMarking = new List<Marking>();
            unFinishedMarking.Add(InitMarking);
            int numOfCause = 0;


            while (unFinishedMarking.Count != 0)
            {
                Marking curMarking = unFinishedMarking[0];
                unFinishedMarking.Remove(curMarking);

                #region Declaration of variables
                IMatchesExact<Rule_enterAutonomousStartEvent.IMatch_enterAutonomousStartEvent> matchesEnterStart = actions.enterAutonomousStartEvent.Match(graph, 10, curMarking);
                IMatchesExact<Rule_leaveStartEvent.IMatch_leaveStartEvent> matchesleaveStart = actions.leaveStartEvent.Match(graph, 10, curMarking);
                IMatchesExact<Rule_enterParallelGateway.IMatch_enterParallelGateway> matchesenterParallelGateway = actions.enterParallelGateway.Match(graph, 10, curMarking);
                IMatchesExact<Rule_leaveParallelGateway.IMatch_leaveParallelGateway> matchesleaveParallelGateway = actions.leaveParallelGateway.Match(graph, 10, curMarking);
                IMatchesExact<Rule_enterTask.IMatch_enterTask> matchesenterTask = actions.enterTask.Match(graph, 10, curMarking);
                IMatchesExact<Rule_leaveTaskOneOut.IMatch_leaveTaskOneOut> matchesleaveTaskOneOut = actions.leaveTaskOneOut.Match(graph, 10, curMarking);
                IMatchesExact<Rule_enterEndEvent.IMatch_enterEndEvent> matchesenterEndEvent = actions.enterEndEvent.Match(graph, 10, curMarking);
                IMatchesExact<Rule_enterExclusiveGateway.IMatch_enterExclusiveGateway> matenterExclusiveGateway = actions.enterExclusiveGateway.Match(graph, 10, curMarking);
                IMatchesExact<Rule_leaveDataExclusiveGateway.IMatch_leaveDataExclusiveGateway> matleaveDataExclusiveGateway = actions.leaveDataExclusiveGateway.Match(graph, 10, curMarking);
                IMatchesExact<Rule_enterSubprocess.IMatch_enterSubprocess> matenterSubprocess = actions.enterSubprocess.Match(graph, 10, curMarking);
                IMatchesExact<Rule_terminateProcessNormal.IMatch_terminateProcessNormal> matterminateProcessNormal = actions.terminateProcessNormal.Match(graph, 10, curMarking);

                IMatchesExact<Rule_leaveSubprocessNormal.IMatch_leaveSubprocessNormal> matleaveSubprocessNormal = actions.leaveSubprocessNormal.Match(graph, 10, curMarking);
                IMatchesExact<Rule_leaveProcessNormal.IMatch_leaveProcessNormal> matleaveProcessNormal = actions.leaveProcessNormal.Match(graph, 10, curMarking);

                IMatchesExact<Rule_enterThrowErrorEvent.IMatch_enterThrowErrorEvent> matenterThrowErrorEvent = actions.enterThrowErrorEvent.Match(graph, 10, curMarking);
                IMatchesExact<Rule_leaveThrowErrorEvent.IMatch_leaveThrowErrorEvent> matleaveThrowErrorEvent = actions.leaveThrowErrorEvent.Match(graph, 10, curMarking);

                IMatchesExact<Rule_leaveSignalOrMessageOrCancelCatchIntermediateEvent.IMatch_leaveSignalOrMessageOrCancelCatchIntermediateEvent> matleaveSignalOrMessageOrCancelCatchIntermediateEvent = actions.leaveSignalOrMessageOrCancelCatchIntermediateEvent.Match(graph, 10, curMarking);

                IMatchesExact<Rule_traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions.IMatch_traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions> mattraverseIntermediateErrorEvent_boundaryCatchImplicitExceptions = actions.traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions.Match(graph, 10, curMarking);
                IMatchesExact<Rule_enterAutonomousBoundaryEvent.IMatch_enterAutonomousBoundaryEvent> matenterAutonomousBoundaryEvent = actions.enterAutonomousBoundaryEvent.Match(graph, 10, curMarking);
                IMatchesExact<Rule_leaveAutonomousBoundaryEvent.IMatch_leaveAutonomousBoundaryEvent> matleaveAutonomousBoundaryEvent = actions.leaveAutonomousBoundaryEvent.Match(graph, 10, curMarking);
                IMatchesExact<Rule_enterIntermediateNoneOrTimerEvent.IMatch_enterIntermediateNoneOrTimerEvent> matenterIntermediateNoneOrTimerEvent = actions.enterIntermediateNoneOrTimerEvent.Match(graph, 10, curMarking);
                IMatchesExact<Rule_leaveIntermediateNoneOrTimerEvent.IMatch_leaveIntermediateNoneOrTimerEvent> matleaveIntermediateNoneOrTimerEvent = actions.leaveIntermediateNoneOrTimerEvent.Match(graph, 10, curMarking);
                //added four 5 new rules
                IMatchesExact<Rule_enterInclusiveGateway.IMatch_enterInclusiveGateway> matenterInclusiveGateway = actions.enterInclusiveGateway.Match(graph,10,curMarking);
                IMatchesExact<Rule_leaveInclusiveGatewayJoin.IMatch_leaveInclusiveGatewayJoin> matleaveInclusiveJoin = actions.leaveInclusiveGatewayJoin.Match(graph,10,curMarking);
                IMatchesExact<Rule_leaveInclusiveGatewaySplitTwo.IMatch_leaveInclusiveGatewaySplitTwo> matleaveIncluSplitTwo=actions.leaveInclusiveGatewaySplitTwo.Match(graph,10,curMarking);
                IMatchesExact<Rule_leaveInclusiveGatewaySplitThree.IMatch_leaveInclusiveGatewaySplitThree> matleaveIncluSplitThree = actions.leaveInclusiveGatewaySplitThree.Match(graph, 10, curMarking);
                IMatchesExact<Rule_enterMessageCatchIntermediateEventFake.IMatch_enterMessageCatchIntermediateEventFake> matenterMessageInterFake = actions.enterMessageCatchIntermediateEventFake.Match(graph, 10, curMarking);
                #endregion

                #region enterStart
                if (matchesEnterStart.Count != 0)
                {
                    IStartEvent startevent;
                    foreach (var match in matchesEnterStart)
                    {
                        actions.enterAutonomousStartEvent.Modify(graph, match as Rule_enterAutonomousStartEvent.IMatch_enterAutonomousStartEvent, out mNewMarking, out curMarking1, out startevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, startevent, "enterAutonomousStartEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, startevent, "enterAutonomousStartEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, startevent, "enterAutonomousStartEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveStart
                if (matchesleaveStart.Count != 0)
                {
                    IStartEvent startevent;
                    foreach (var match in matchesleaveStart)
                    {
                        actions.leaveStartEvent.Modify(graph, match as Rule_leaveStartEvent.IMatch_leaveStartEvent, out mNewMarking, out curMarking1, out startevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, startevent, "leaveStartEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, startevent, "leaveStartEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, startevent, "leaveStartEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterparallel
                if (matchesenterParallelGateway.Count != 0)
                {
                    IGateway gate;
                    foreach (var match in matchesenterParallelGateway)
                    {
                        actions.enterParallelGateway.Modify(graph, match as Rule_enterParallelGateway.IMatch_enterParallelGateway, out mNewMarking, out curMarking1, out gate);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, gate, "enterParallelGateway");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, gate, "enterParallelGateway");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, gate, "enterParallelGateway");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveParallelGateway
                if (matchesleaveParallelGateway.Count != 0)
                {
                    IGateway gate;
                    foreach (var match in matchesleaveParallelGateway)
                    {
                        actions.leaveParallelGateway.Modify(graph, match as Rule_leaveParallelGateway.IMatch_leaveParallelGateway, out mNewMarking, out curMarking1, out gate);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, gate, "leaveParallelGateway");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, gate, "leaveParallelGateway");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, gate, "leaveParallelGateway");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);

                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterTask
                if (matchesenterTask.Count != 0)
                {
                    ITask task;
                    foreach (var match in matchesenterTask)
                    {
                        actions.enterTask.Modify(graph, match as Rule_enterTask.IMatch_enterTask, out mNewMarking, out curMarking1, out task);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, task, "enterTask");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, task, "enterTask");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, task, "enterTask");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveTaskOneOut
                if (matchesleaveTaskOneOut.Count != 0)
                {
                    ITask task;
                    foreach (var match in matchesleaveTaskOneOut)
                    {
                        actions.leaveTaskOneOut.Modify(graph, match as Rule_leaveTaskOneOut.IMatch_leaveTaskOneOut, out mNewMarking, out curMarking1, out task);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, task, "leaveTaskOneOut");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                //graph.RemoveEdges(mNewMarking);
                                //graph.Remove(mNewMarking);
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, task, "leaveTaskOneOut");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "enterAutonomousBoundaryEvent");

                                //}
                            }
                            //else
                            //{
                            //    graph.RemoveEdges(mNewMarking);
                            //    graph.Remove(mNewMarking);
                            //}
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterEndEvent
                if (matchesenterEndEvent.Count != 0)
                {
                    IEndEvent endevent;
                    foreach (var match in matchesenterEndEvent)
                    {
                        actions.enterEndEvent.Modify(graph, match as Rule_enterEndEvent.IMatch_enterEndEvent, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "enterEndEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "enterEndEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "enterEndEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterExclusiveGateway

                if (matenterExclusiveGateway.Count != 0)
                {
                    IGateway gate;
                    foreach (var match in matenterExclusiveGateway)
                    {
                        actions.enterExclusiveGateway.Modify(graph, match as Rule_enterExclusiveGateway.IMatch_enterExclusiveGateway, out mNewMarking, out curMarking1, out gate);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, gate, "enterExclusiveGateway");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, gate, "enterExclusiveGateway");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, gate, "enterExclusiveGateway");

                                //}

                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveDataExclusiveGateway
                if (matleaveDataExclusiveGateway.Count != 0)
                {
                    IGateway gate;
                    foreach (var match in matleaveDataExclusiveGateway)
                    {
                        actions.leaveDataExclusiveGateway.Modify(graph, match as Rule_leaveDataExclusiveGateway.IMatch_leaveDataExclusiveGateway, out mNewMarking, out curMarking1, out gate);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, gate, "leaveDataExclusiveGateway");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, gate, "leaveDataExclusiveGateway");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, gate, "leaveDataExclusiveGateway");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterSubprocess
                if (matenterSubprocess.Count != 0)
                {
                    IBlockActivity blockActivity;
                    foreach (var match in matenterSubprocess)
                    {
                        actions.enterSubprocess.Modify(graph, match as Rule_enterSubprocess.IMatch_enterSubprocess, out mNewMarking, out curMarking1, out blockActivity);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNewForSub.Apply(graph, curMarking1, mNewMarking, blockActivity, "enterSubprocess");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2ForSub.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, blockActivity, "enterSubprocess");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, blockActivity, "enterSubprocess");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region terminateProcessNormal
                if (matterminateProcessNormal.Count != 0)
                {
                    IFlowElementsContainer flowEleCont;
                    foreach (var match in matterminateProcessNormal)
                    {
                        actions.terminateProcessNormal.Modify(graph, match as Rule_terminateProcessNormal.IMatch_terminateProcessNormal, out mNewMarking, out curMarking1, out flowEleCont);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, flowEleCont, "terminateProcessNormal");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                //graph.RemoveEdges(mNewMarking);
                                //graph.Remove(mNewMarking);
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, flowEleCont, "terminateProcessNormal");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "enterAutonomousBoundaryEvent");

                                //}
                            }
                            //else
                            //{
                            //    graph.RemoveEdges(mNewMarking);
                            //    graph.Remove(mNewMarking);
                            //}
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterAutonomousBoundaryEvent
                if (matenterAutonomousBoundaryEvent.Count != 0)
                {
                    IActivity endevent;
                    foreach (var match in matenterAutonomousBoundaryEvent)
                    {
                        actions.enterAutonomousBoundaryEvent.Modify(graph, match as Rule_enterAutonomousBoundaryEvent.IMatch_enterAutonomousBoundaryEvent, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "enterAutonomousBoundaryEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                //graph.RemoveEdges(mNewMarking);
                                //graph.Remove(mNewMarking);
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "enterAutonomousBoundaryEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "enterAutonomousBoundaryEvent");

                                //}
                            }
                            //else
                            //{
                            //    graph.RemoveEdges(mNewMarking);
                            //    graph.Remove(mNewMarking);
                            //}
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveSubprocessNormal
                if (matleaveSubprocessNormal.Count != 0)
                {
                    IBlockActivity blockActivity;
                    foreach (var match in matleaveSubprocessNormal)
                    {
                        actions.leaveSubprocessNormal.Modify(graph, match as Rule_leaveSubprocessNormal.IMatch_leaveSubprocessNormal, out mNewMarking, out curMarking1, out blockActivity);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, blockActivity, "leaveSubprocessNormal");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, blockActivity, "leaveSubprocessNormal");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, blockActivity, "enterSubprocess");

                                //}
                            }

                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveProcessNormal
                if (matleaveProcessNormal.Count != 0)
                {
                    IWorkflowProcess workprocess;
                    foreach (var match in matleaveProcessNormal)
                    {
                        actions.leaveProcessNormal.Modify(graph, match as Rule_leaveProcessNormal.IMatch_leaveProcessNormal, out mNewMarking, out curMarking1, out workprocess);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, workprocess, "leaveProcessNormal");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, workprocess, "leaveProcessNormal");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, workprocess, "leaveProcessNormal");

                                //}
                            }

                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterThrowErrorEvent
                if (matenterThrowErrorEvent.Count != 0)
                {
                    IEndEvent endevent;
                    foreach (var match in matenterThrowErrorEvent)
                    {
                        actions.enterThrowErrorEvent.Modify(graph, match as Rule_enterThrowErrorEvent.IMatch_enterThrowErrorEvent, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "enterThrowErrorEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "enterThrowErrorEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "enterThrowErrorEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveThrowErrorEvent
                if (matleaveThrowErrorEvent.Count != 0)
                {
                    IEndEvent endevent;
                    foreach (var match in matleaveThrowErrorEvent)
                    {
                        actions.leaveThrowErrorEvent.Modify(graph, match as Rule_leaveThrowErrorEvent.IMatch_leaveThrowErrorEvent, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "leaveThrowErrorEvent");

                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "leaveThrowErrorEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "leaveThrowErrorEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveSignalOrMessageOrCancelCatchIntermediateEvent
                if (matleaveSignalOrMessageOrCancelCatchIntermediateEvent.Count != 0)
                {
                    IIntermediateCatchEvent endevent;
                    foreach (var match in matleaveSignalOrMessageOrCancelCatchIntermediateEvent)
                    {
                        actions.leaveSignalOrMessageOrCancelCatchIntermediateEvent.Modify(graph, match as Rule_leaveSignalOrMessageOrCancelCatchIntermediateEvent.IMatch_leaveSignalOrMessageOrCancelCatchIntermediateEvent, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "leaveSignalOrMessageOrCancelCatchIntermediateEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "leaveSignalOrMessageOrCancelCatchIntermediateEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "leaveSignalOrMessageOrCancelCatchIntermediateEvent");

                                //}
                            }

                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions
                if (mattraverseIntermediateErrorEvent_boundaryCatchImplicitExceptions.Count != 0)
                {
                    IBlockActivity endevent;
                    foreach (var match in mattraverseIntermediateErrorEvent_boundaryCatchImplicitExceptions)
                    {
                        actions.traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions.Modify(graph, match as Rule_traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions.IMatch_traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "traverseIntermediateErrorEvent_boundaryCatchImplicitExceptions");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveAutonomousBoundaryEvent
                if (matleaveAutonomousBoundaryEvent.Count != 0)
                {
                    IActivity endevent;
                    foreach (var match in matleaveAutonomousBoundaryEvent)
                    {
                        actions.leaveAutonomousBoundaryEvent.Modify(graph, match as Rule_leaveAutonomousBoundaryEvent.IMatch_leaveAutonomousBoundaryEvent, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "leaveAutonomousBoundaryEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "leaveAutonomousBoundaryEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "leaveAutonomousBoundaryEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterIntermediateNoneOrTimerEvent
                if (matenterIntermediateNoneOrTimerEvent.Count != 0)
                {
                    IIntermediateEvent endevent;
                    foreach (var match in matenterIntermediateNoneOrTimerEvent)
                    {
                        actions.enterIntermediateNoneOrTimerEvent.Modify(graph, match as Rule_enterIntermediateNoneOrTimerEvent.IMatch_enterIntermediateNoneOrTimerEvent, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "enterIntermediateNoneOrTimerEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "enterIntermediateNoneOrTimerEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "enterIntermediateNoneOrTimerEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveIntermediateNoneOrTimerEvent
                if (matleaveIntermediateNoneOrTimerEvent.Count != 0)
                {
                    IIntermediateEvent endevent;
                    foreach (var match in matleaveIntermediateNoneOrTimerEvent)
                    {
                        actions.leaveIntermediateNoneOrTimerEvent.Modify(graph, match as Rule_leaveIntermediateNoneOrTimerEvent.IMatch_leaveIntermediateNoneOrTimerEvent, out mNewMarking, out curMarking1, out endevent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, endevent, "leaveIntermediateNoneOrTimerEvent");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, endevent, "leaveIntermediateNoneOrTimerEvent");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "leaveIntermediateNoneOrTimerEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region enterInclusiveGateway
                if (matenterInclusiveGateway.Count != 0)
                {
                    IGateway IncluGateway;
                    foreach (var match in matenterInclusiveGateway)
                    {
                        actions.enterInclusiveGateway.Modify(graph, match as Rule_enterInclusiveGateway.IMatch_enterInclusiveGateway, out mNewMarking, out curMarking1, out IncluGateway);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, IncluGateway, "enterInclusiveGateway");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, IncluGateway, "enterInclusiveGateway");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "leaveIntermediateNoneOrTimerEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveInclusiveGatewayJoin
                if (matleaveInclusiveJoin.Count != 0)
                {
                    IGateway IncluGateway;
                    foreach (var match in matleaveInclusiveJoin)
                    {
                        actions.leaveInclusiveGatewayJoin.Modify(graph, match as Rule_leaveInclusiveGatewayJoin.IMatch_leaveInclusiveGatewayJoin, out mNewMarking, out curMarking1, out IncluGateway);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, IncluGateway, "leaveInclusiveGatewayJoin");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, IncluGateway, "leaveInclusiveGatewayJoin");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "leaveIntermediateNoneOrTimerEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
                #region leaveInclusiveGatewaySplitTwo
                if (matleaveIncluSplitTwo.Count != 0)
                {
                    IGateway IncluGateway;
                    foreach (var match in matleaveIncluSplitTwo)
                    {
                        IMarking mNew1 = new Marking();
                        IMarking mNew2 = new Marking();
                        actions.leaveInclusiveGatewaySplitTwo.Modify(graph, match as Rule_leaveInclusiveGatewaySplitTwo.IMatch_leaveInclusiveGatewaySplitTwo, out mNewMarking, out mNew1, out mNew2, out curMarking1, out IncluGateway);
                        unFinishedMarking.Add(mNewMarking as Marking);
                        numOfCause++;
                        unFinishedMarking.Add(mNew1 as Marking);
                        numOfCause++;
                        unFinishedMarking.Add(mNew2 as Marking);
                        numOfCause++;
                        break;
                    }
                }
                #endregion
                #region leaveInclusiveGatewaySplitThree
                if (matleaveIncluSplitThree.Count != 0)
                {
                    IGateway IncluGateway;
                    foreach (var match in matleaveIncluSplitThree)
                    {
                        IMarking mNew1 = new Marking();
                        IMarking mNew2 = new Marking();
                        IMarking mNew3 = new Marking();
                        IMarking mNew4 = new Marking();
                        IMarking mNew5 = new Marking();
                        IMarking mNew6 = new Marking();
                        actions.leaveInclusiveGatewaySplitThree.Modify(graph, match as Rule_leaveInclusiveGatewaySplitThree.IMatch_leaveInclusiveGatewaySplitThree, out mNewMarking,out mNew1,out mNew2,out mNew3,out mNew4,out mNew5,out mNew6, out curMarking1, out IncluGateway);
                        unFinishedMarking.Add(mNewMarking as Marking);
                        numOfCause++;
                        unFinishedMarking.Add(mNew1 as Marking);
                        numOfCause++;
                        unFinishedMarking.Add(mNew2 as Marking);
                        numOfCause++;
                        unFinishedMarking.Add(mNew3 as Marking);
                        numOfCause++;
                        unFinishedMarking.Add(mNew4 as Marking);
                        numOfCause++;
                        unFinishedMarking.Add(mNew5 as Marking);
                        numOfCause++;
                        unFinishedMarking.Add(mNew6 as Marking);
                        numOfCause++;
                        break;
                       
                    }
                }
                #endregion
                #region enterMessageCatchIntermediateEventFake
                if (matenterMessageInterFake.Count != 0)
                {
                    IIntermediateCatchEvent interCatchEvent;
                    foreach (var match in matenterMessageInterFake)
                    {
                        actions.enterMessageCatchIntermediateEventFake.Modify(graph, match as Rule_enterMessageCatchIntermediateEventFake.IMatch_enterMessageCatchIntermediateEventFake, out mNewMarking, out curMarking1, out interCatchEvent);
                        bool flagCM1M2IfNew = actions.ConnectM1toM2IfNew.Apply(graph, curMarking1, mNewMarking, interCatchEvent, "enterMessageCatchIntermediateEventFake");
                        if (!flagCM1M2IfNew)
                        {
                            IMarking m3 = null;
                            bool flagEguivalent = actions.GetEquivalentOfM2.Apply(graph, curMarking1, mNewMarking, ref m3);
                            actions.DelM.Apply(graph, mNewMarking);
                            if (m3 != null)
                            {
                                bool flagConnectNotYet = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, m3, interCatchEvent, "enterMessageCatchIntermediateEventFake");
                                //if (!flagConnectNotYet)
                                //{
                                //    bool flagConn2 = actions.ConnectIfNotYetConnected.Apply(graph, curMarking1, curMarking1, IncluGateway, "leaveIntermediateNoneOrTimerEvent");

                                //}
                            }
                            //graph.RemoveEdges(mNewMarking);
                            //graph.Remove(mNewMarking);
                        }
                        else
                        {
                            unFinishedMarking.Add(mNewMarking as Marking);
                            numOfCause++;
                        }
                    }
                }
                #endregion
            }

            //save the file at the original place but with a postfix after.grs
            List<string> exportParameters = new List<string>();
            string[] filehead = fileDirectory.Split('.');
            string afterFile = filehead[0] + "After.grs";
            exportParameters.Add(afterFile);
            Porter.Export(graph, exportParameters);

            return afterFile;
        }

        private string ParseXPDLIntoGrs(string fileDirectory,out bool flagParseSuccess)
        {
            string[] filehead = fileDirectory.Split('.');
            string afterFile=ParseXPDL.parseXPDL(fileDirectory,out flagParseSuccess);
            return afterFile;
        }

        //this is from dircted graph with output parameter
        public List<CauseNode> ReadModelMarkingFileAndParsing(string filePath)
        {

            List<HMarking> MarkingList = new List<HMarking>();

            Model modelIns = new Model();
            List<Task> listTask = new List<Task>();
            List<Gateway> listGateway = new List<Gateway>();
            List<Seque> listSeque = new List<Seque>();
            List<ProcIn> listProIn = new List<ProcIn>();

            List<Token> listToken = new List<Token>();
            //List<Mnext> listMnext = new List<Mnext>();
            List<Melem> listMelem = new List<Melem>();
            List<EdgeTokens> listEdgeTokens = new List<EdgeTokens>();
            List<Pi2Mark> listPi2Mark = new List<Pi2Mark>();
            List<LoopCharacteristcs> listLoop = new List<LoopCharacteristcs>();

            List<MnextWithCause> listMnextCause = new List<MnextWithCause>();
            List<EdgeFromMark> listFromMark = new List<EdgeFromMark>();
            List<EdgeToMark> listToMark = new List<EdgeToMark>();
            List<CauseNode> listCauseNode = new List<CauseNode>();

            List<BlockActivity> listBlock = new List<BlockActivity>();
            List<IntermediateCatchEvent> listCatch = new List<IntermediateCatchEvent>();
            List<IntermediateThrowEvent> listThrow = new List<IntermediateThrowEvent>();

            Regex patOfTask = new Regex(@"Task(?=[(])");
            Regex patOfStartEvent = new Regex(@"StartEvent(?=[(])");
            Regex patOfEndEvent = new Regex(@"EndEvent(?=[(])");
            Regex patOfGateway = new Regex(@"Gateway(?=[(])");
            Regex patOfMarking = new Regex(@":Marking(?=[(])");
            Regex patOfMnext = new Regex(@"Mnext(?=[(])");
            Regex patOfMelem = new Regex(@"Melem(?=[(])");
            Regex patOfToken = new Regex(@":Token[(]");
            Regex patOfEdgeTokens = new Regex(@":Tokens[(]");
            Regex patOfSeqFlow = new Regex(@"_SequenceFlow(?=[(])");
            Regex patOfProI = new Regex(@"ProcessInstance(?=[(])");
            Regex patOfPi2Marking = new Regex(@"pi2mark(?=[(])");
            //Added Nov.3rd for testing the loop
            Regex patOfLoopChar = new Regex(@"loopCharacteristics(?=[(])");
            //Added Sep. 5th 2014 for adding MnextCause
            Regex patOfMnextCause = new Regex(@"MnextWithCause(?=[(])");
            Regex patOfFromMark = new Regex(@"FromMarking");
            Regex patOfToMark = new Regex(@"ToMarking");
            Regex patOfCause = new Regex(@"_Cause");

            Regex patOfBlock = new Regex(@"new :BlockActivity");
            Regex patOfInterCatch = new Regex(@"new :IntermediateCatchEvent");
            Regex patOfInterThrow = new Regex(@"new :IntermediateThrowEvent");

            Regex patOfName = new Regex("(?<=Name = \")\\w*(?=[\"])");
            Regex patOfID = new Regex("(?<=\\$ = \").\\S*(?=\")");

            Regex patOfGatewayType = new Regex("(?<=GatewayType::)\\w*(?=[,])");

            Regex patOfOrgMn = new Regex("(?<=@[(]\").\\S*(?=\"[)] -)");
            Regex patOfTargMn = new Regex("(?<=> @[(]\").\\S*(?=\"[)])");
            Regex patOfState = new Regex("(?<=state::)\\w*(?=[)])");
            //Added Nov.3rd 2013 
            Regex patOfOrginLoop = new Regex("(?<=@\\(\").\\S*(?=\"\\)-:loop)");

            //Added Sep. 5th 2014 for adding MnextCause
            Regex patOfMnextCauseRuleName = new Regex(@"MnextWithCause(?=[(])");
            Regex patOfRuleName = new Regex("(?<=ruleName = \").\\S*(?=\")");

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string strReadLine = sr.ReadLine();

                    #region match of task
                    Match matOfTask = patOfTask.Match(strReadLine);
                    if (matOfTask.Success)
                    {

                        Task t = new Task();
                        t.Name = patOfName.Match(strReadLine.Trim()).Value;
                        t.ID = patOfID.Match(strReadLine.Trim()).Value;
                        listTask.Add(t);
                        continue;
                    }
                    #endregion
                    #region match of startevent
                    Match matOfStart = patOfStartEvent.Match(strReadLine);
                    if (matOfStart.Success)
                    {

                        StartEvent startE = new StartEvent();
                        startE.Name = patOfName.Match(strReadLine.Trim()).Value;
                        startE.ID = patOfID.Match(strReadLine.Trim()).Value;
                        modelIns.listStartE.Add(startE);
                        continue;
                    }
                    #endregion
                    #region match of end
                    Match matOfEnd = patOfEndEvent.Match(strReadLine);
                    if (matOfEnd.Success)
                    {

                        EndEvent endE = new EndEvent();
                        endE.Name = patOfName.Match(strReadLine.Trim()).Value;
                        endE.ID = patOfID.Match(strReadLine.Trim()).Value;
                        modelIns.listEndE.Add(endE);
                        continue;
                    }
                    #endregion
                    #region match gateway
                    Match matOfGateway = patOfGateway.Match(strReadLine);
                    if (matOfGateway.Success)
                    {

                        Gateway g = new Gateway();
                        g.Type = patOfGatewayType.Match(strReadLine.Trim()).Value;
                        g.ID = patOfID.Match(strReadLine.Trim()).Value;
                        listGateway.Add(g);
                        continue;
                    }
                    #endregion
                    #region match marking
                    Match matOfMarking = patOfMarking.Match(strReadLine);
                    if (matOfMarking.Success)
                    {

                        HMarking mark = new HMarking();
                        mark.ID = patOfID.Match(strReadLine.Trim()).Value;
                        //mark.PreMarkingIDlist = new List<string>();
                        //mark.NextMarkingIDlist = new List<string>();
                        MarkingList.Add(mark);
                        continue;
                    }
                    #endregion
                    //Added Sep. 5th 2014
                    #region match MnextCause
                    Match matOfMnextCause = patOfMnextCause.Match(strReadLine);
                    if (matOfMnextCause.Success)
                    {
                        MnextWithCause MnextCause = new MnextWithCause();
                        MnextCause.ID = patOfID.Match(strReadLine.Trim()).Value;
                        MnextCause.ruleName = patOfRuleName.Match(strReadLine.Trim()).Value;
                        listMnextCause.Add(MnextCause);
                        continue;
                    }
                    #endregion
                    #region match of Token
                    Match matOfToken = patOfToken.Match(strReadLine);
                    if (matOfToken.Success)
                    {

                        Token to = new Token();
                        to.ID = patOfID.Match(strReadLine.Trim()).Value;
                        listToken.Add(to);
                        continue;
                    }
                    #endregion
                    #region match of Melem
                    Match matOfMelem = patOfMelem.Match(strReadLine);
                    if (matOfMelem.Success)
                    {
                        Melem me = new Melem();
                        me.MarkID = patOfOrgMn.Match(strReadLine.Trim()).Value;
                        me.TokenID = patOfTargMn.Match(strReadLine.Trim()).Value;
                        listMelem.Add(me);
                        continue;
                    }
                    #endregion
                    #region match of Pro2Mark
                    Match matOfPro2Mark = patOfPi2Marking.Match(strReadLine);
                    if (matOfPro2Mark.Success)
                    {

                        Pi2Mark me = new Pi2Mark();
                        me.ProID = patOfOrgMn.Match(strReadLine.Trim()).Value;
                        me.MarkID = patOfTargMn.Match(strReadLine.Trim()).Value;
                        listPi2Mark.Add(me);
                        continue;
                    }
                    #endregion
                    #region match of EdgeTokens
                    Match matOfEdgeTokens = patOfEdgeTokens.Match(strReadLine);
                    if (matOfEdgeTokens.Success)
                    {
                        EdgeTokens edget = new EdgeTokens();
                        edget.ContainerID = patOfOrgMn.Match(strReadLine.Trim()).Value;
                        edget.TokenID = patOfTargMn.Match(strReadLine.Trim()).Value;
                        listEdgeTokens.Add(edget);
                        continue;
                    }
                    #endregion
                    #region match sequence
                    Match matOfSeq = patOfSeqFlow.Match(strReadLine);
                    if (matOfSeq.Success)
                    {
                        Seque g = new Seque();
                        g.ID = patOfID.Match(strReadLine.Trim()).Value;
                        listSeque.Add(g);
                        continue;
                    }
                    #endregion
                    #region match ProcessInstance
                    Match matOfProI = patOfProI.Match(strReadLine);
                    if (matOfProI.Success)
                    {
                        ProcIn g = new ProcIn();
                        g.ID = patOfID.Match(strReadLine.Trim()).Value;
                        g.State = patOfState.Match(strReadLine.Trim()).Value;
                        listProIn.Add(g);
                        continue;
                    }
                    #endregion
                    #region match loopChara
                    Match matOfLoop = patOfLoopChar.Match(strReadLine);
                    if (matOfLoop.Success)
                    {
                        LoopCharacteristcs loopCh = new LoopCharacteristcs();
                        loopCh.TaskID = patOfOrginLoop.Match(strReadLine.Replace(" ", "")).Value;
                        listLoop.Add(loopCh);
                        continue;
                    }
                    #endregion
                    #region match of FromMarking
                    Match matOfFromMark = patOfFromMark.Match(strReadLine);
                    if (matOfFromMark.Success)
                    {
                        EdgeFromMark mn = new EdgeFromMark();
                        mn.OrgID = patOfOrgMn.Match(strReadLine.Trim()).Value;
                        mn.TargId = patOfTargMn.Match(strReadLine.Trim()).Value;
                        listFromMark.Add(mn);
                        continue;
                    }
                    #endregion
                    #region match of ToMarking
                    Match matOfToMark = patOfToMark.Match(strReadLine);
                    if (matOfToMark.Success)
                    {
                        EdgeToMark mn = new EdgeToMark();
                        mn.OrgID = patOfOrgMn.Match(strReadLine.Trim()).Value;
                        mn.TargId = patOfTargMn.Match(strReadLine.Trim()).Value;
                        listToMark.Add(mn);
                        continue;
                    }
                    #endregion
                    #region match of Cause
                    Match matOfCause = patOfCause.Match(strReadLine);
                    if (matOfCause.Success)
                    {
                        CauseNode mn = new CauseNode();
                        mn.ID = patOfID.Match(strReadLine.Trim()).Value;
                        mn.MnextCauseID = patOfOrgMn.Match(strReadLine.Trim()).Value;
                        mn.ActivityEle.ID = patOfTargMn.Match(strReadLine.Trim()).Value;
                        listCauseNode.Add(mn);
                        continue;
                    }
                    #endregion
                    #region match of BlockActivity
                    Match matOfBlock = patOfBlock.Match(strReadLine);
                    if (matOfBlock.Success)
                    {
                        BlockActivity b = new BlockActivity();
                        b.Name = patOfName.Match(strReadLine.Trim()).Value;
                        b.ID = patOfID.Match(strReadLine.Trim()).Value;
                        listBlock.Add(b);
                        continue;
                    }
                    #endregion
                    #region match of IntermediaCatchEvent
                    Match matOfInCatch = patOfInterCatch.Match(strReadLine);
                    if (matOfInCatch.Success)
                    {
                        IntermediateCatchEvent t = new IntermediateCatchEvent();
                        t.Name = patOfName.Match(strReadLine.Trim()).Value;
                        t.ID = patOfID.Match(strReadLine.Trim()).Value;
                        listCatch.Add(t);
                        continue;
                    }
                    #endregion
                    #region match of IntermediaThrowEvent
                    Match matOfInThrow = patOfInterThrow.Match(strReadLine);
                    if (matOfInThrow.Success)
                    {
                        IntermediateThrowEvent t = new IntermediateThrowEvent();
                        t.Name = patOfName.Match(strReadLine.Trim()).Value;
                        t.ID = patOfID.Match(strReadLine.Trim()).Value;
                        listThrow.Add(t);
                        continue;
                    }
                    #endregion
                }
            }
            modelIns.listTask = listTask;
            modelIns.listGateway = listGateway;

            //Filling in the relationship between Marking and MnextClause: fromMarking
            foreach (EdgeFromMark edgeFrom in listFromMark)
            {
                int ind0 = listMnextCause.FindIndex(x => x.ID == edgeFrom.TargId);
                listMnextCause[ind0].OrgMarkingID = edgeFrom.OrgID;
            }
            //Filling in the relationship between Marking and MnextClause: toMarking
            foreach (EdgeToMark edgeTo in listToMark)
            {
                int ind0 = listMnextCause.FindIndex(x => x.ID == edgeTo.OrgID);
                listMnextCause[ind0].TargMarkingID = edgeTo.TargId;
            }
            //Filling in the cause (activity) in MnextCause
            foreach (CauseNode c in listCauseNode)
            {
                int ind0 = listMnextCause.FindIndex(x => x.ID == c.MnextCauseID);
                listMnextCause[ind0].CauseNodeID = c.ID;
                #region filling in the elements in each Activity
                if (listTask.Find(x => x.ID == c.ActivityEle.ID) != null)
                {
                    if (listLoop.Find(x => x.TaskID == c.ActivityEle.ID) != null)
                    {
                        c.ActivityEle.Type = TypeOfElement.LoopTask;
                        c.ActivityEle.Name = listTask.Find(x => x.ID == c.ActivityEle.ID).Name;

                    }
                    else
                    {
                        c.ActivityEle.Type = TypeOfElement.Task;
                        c.ActivityEle.Name = listTask.Find(x => x.ID == c.ActivityEle.ID).Name;
                    }
                }
                if (listGateway.Find(x => x.ID == c.ActivityEle.ID) != null)
                {
                    c.ActivityEle.Type = TypeOfElement.GateWay;
                    c.ActivityEle.Name = listGateway.Find(x => x.ID == c.ActivityEle.ID).Type;
                }
                if (listSeque.Find(x => x.ID == c.ActivityEle.ID) != null)
                {
                    c.ActivityEle.Type = TypeOfElement.Sequence;
                }
                if (modelIns.listStartE.Find(x => x.ID == c.ActivityEle.ID) != null)
                {
                    c.ActivityEle.Name = modelIns.listStartE.Find(x => x.ID == c.ActivityEle.ID).Name;
                    c.ActivityEle.Type = TypeOfElement.StartEvent;
                }
                if (modelIns.listEndE.Find(x => x.ID == c.ActivityEle.ID) != null)
                {
                    c.ActivityEle.Name = modelIns.listEndE.Find(x => x.ID == c.ActivityEle.ID).Name;
                    c.ActivityEle.Type = TypeOfElement.EndEvent;
                }
                if (listBlock.Find(x => x.ID == c.ActivityEle.ID) != null)
                {
                    c.ActivityEle.Type = TypeOfElement.BlockActivity;
                    c.ActivityEle.Name = listBlock.Find(x => x.ID == c.ActivityEle.ID).Name;
                }
                if (listCatch.Find(x => x.ID == c.ActivityEle.ID) != null)
                {
                    c.ActivityEle.Type = TypeOfElement.IntermediateCatchEvent;
                    c.ActivityEle.Name = listCatch.Find(x => x.ID == c.ActivityEle.ID).Name;
                }
                if (listThrow.Find(x => x.ID == c.ActivityEle.ID) != null)
                {
                    c.ActivityEle.Type = TypeOfElement.IntermediateThrowEvent;
                    c.ActivityEle.Name = listThrow.Find(x => x.ID == c.ActivityEle.ID).Name;
                }
                #endregion
            }
            //Filling in the pre and next Marking for each marking, based on MnextWithCause
            //Filling in the pre and next CauseNode for each causeNode, based on MnextWithCause and Marking
            #region
            foreach (MnextWithCause mnextc in listMnextCause)
            {
                int n = MarkingList.FindIndex(x => x.ID == mnextc.TargMarkingID);
                if (n > -1 && MarkingList.Find(x => x.ID == mnextc.TargMarkingID) != null)
                {
                    MarkingList[n].PreMarkingIDlist.Add(mnextc.OrgMarkingID);
                }

                int n0 = MarkingList.FindIndex(x => x.ID == mnextc.OrgMarkingID);
                if (n0 > -1 && MarkingList.Find(x => x.ID == mnextc.TargMarkingID) != null)
                {
                    MarkingList[n0].NextMarkingIDlist.Add(mnextc.TargMarkingID);
                }
                int n1 = listCauseNode.FindIndex(x => x.ID == mnextc.CauseNodeID);
                listCauseNode[n1].ruleName = mnextc.ruleName;
                List<MnextWithCause> listMatchNext = listMnextCause.FindAll(x => x.OrgMarkingID == mnextc.TargMarkingID);
                foreach (MnextWithCause nextCause in listMatchNext)
                {
                    listCauseNode[n1].NextCauselist.Add(nextCause.CauseNodeID);
                }
                List<MnextWithCause> listMatchPre = listMnextCause.FindAll(x => x.TargMarkingID == mnextc.OrgMarkingID);
                foreach (MnextWithCause nextCause in listMatchPre)
                {
                    listCauseNode[n1].PreCauselist.Add(nextCause.CauseNodeID);
                }
            }
            #endregion
            //Filling in the process state of Markings
            foreach (ProcIn p in listProIn)
            {
                int ind0 = listPi2Mark.FindIndex(x => x.ProID == p.ID);
                if (ind0 > -1)
                {
                    int ind1 = MarkingList.FindIndex(x => x.ID == listPi2Mark[ind0].MarkID);
                    MarkingList[ind1].ProcessInState = p.State;
                }


            }
            #region Filling Marking's elements
            foreach (EdgeTokens edge in listEdgeTokens)
            {
                int n2 = listMelem.FindIndex(x => x.TokenID == edge.TokenID);
                if (n2 > -1)
                {
                    string mID = listMelem[n2].MarkID;
                    int n3 = MarkingList.FindIndex(x => x.ID == mID);
                    if (n3 > -1)
                    {
                        if (listTask.Find(x => x.ID == edge.ContainerID) != null)
                        {
                            if (listLoop.Find(x => x.TaskID == edge.ContainerID) != null)
                            {
                                Element e = new Element();
                                e.Type = TypeOfElement.LoopTask;
                                e.Name = listTask.Find(x => x.ID == edge.ContainerID).Name;
                                MarkingList[n3].ElmentList.Add(e);
                            }
                            else
                            {
                                Element e = new Element();
                                e.Type = TypeOfElement.Task;
                                e.Name = listTask.Find(x => x.ID == edge.ContainerID).Name;
                                MarkingList[n3].ElmentList.Add(e);
                            }
                        }
                        if (listGateway.Find(x => x.ID == edge.ContainerID) != null)
                        {
                            Element e = new Element();
                            e.Type = TypeOfElement.GateWay;
                            e.Name = listGateway.Find(x => x.ID == edge.ContainerID).Type;
                            MarkingList[n3].ElmentList.Add(e);
                        }
                        if (listSeque.Find(x => x.ID == edge.ContainerID) != null)
                        {
                            Element e = new Element();
                            e.Type = TypeOfElement.Sequence;
                            MarkingList[n3].ElmentList.Add(e);
                        }
                        if (modelIns.listStartE.Find(x => x.ID == edge.ContainerID) != null)
                        {
                            Element e = new Element();
                            e.Name = modelIns.listStartE.Find(x => x.ID == edge.ContainerID).Name;
                            e.Type = TypeOfElement.StartEvent;
                            MarkingList[n3].ElmentList.Add(e);
                        }
                        if (modelIns.listEndE.Find(x => x.ID == edge.ContainerID) != null)
                        {
                            Element e = new Element();
                            e.Name = modelIns.listEndE.Find(x => x.ID == edge.ContainerID).Name;
                            e.Type = TypeOfElement.EndEvent;
                            MarkingList[n3].ElmentList.Add(e);
                        }
                        if (listBlock.Find(x => x.ID == edge.ContainerID) != null)
                        {
                            Element e = new Element();
                            e.Type = TypeOfElement.BlockActivity;
                            e.Name = listBlock.Find(x => x.ID == edge.ContainerID).Name;
                            MarkingList[n3].ElmentList.Add(e);
                        }
                        if (listCatch.Find(x => x.ID == edge.ContainerID) != null)
                        {
                            Element e = new Element();
                            e.Type = TypeOfElement.IntermediateCatchEvent;
                            e.Name = listCatch.Find(x => x.ID == edge.ContainerID).Name;
                            MarkingList[n3].ElmentList.Add(e);
                        }
                        if (listThrow.Find(x => x.ID == edge.ContainerID) != null)
                        {
                            Element e = new Element();
                            e.Type = TypeOfElement.IntermediateThrowEvent;
                            e.Name = listThrow.Find(x => x.ID == edge.ContainerID).Name;
                            MarkingList[n3].ElmentList.Add(e);
                        }
                    }
                }
            }
            #endregion

            //this.originalMarkings = MarkingList;
            return  listCauseNode;
        }

        public List<CauseNode> FilteringCauseNodes(List<CauseNode> CauseNodeList, bool flagOnlyStart, bool flagGatewayAndEvents)
        {
            List<CauseNode> FilteredCauseNodes = new List<CauseNode>();
            foreach (CauseNode m in CauseNodeList)
            {
                if (m.ruleName.Contains("enter") || flagOnlyStart)
                {
                    bool flag = true;
                    switch (m.ActivityEle.Type)
                    {
                        case TypeOfElement.GateWay:
                        case TypeOfElement.IntermediateCatchEvent:
                        case TypeOfElement.IntermediateThrowEvent:
                            flag = flagGatewayAndEvents;
                            break;
                        case TypeOfElement.Task:
                        case TypeOfElement.Empty:
                        case TypeOfElement.EndEvent:
                        case TypeOfElement.StartEvent:
                        case TypeOfElement.BlockActivity:
                        case TypeOfElement.Sequence:
                            flag = true;
                            break;
                    }
                    if (flag)
                    {
                        CauseNode newM = new CauseNode();
                        newM.ID = m.ID;
                        newM.ActivityEle = m.ActivityEle;
                        newM.ruleName = m.ruleName;
                        FilteredCauseNodes.Add(newM);
                    }
                }
            }

            foreach (CauseNode m in FilteredCauseNodes)
            {
                CauseNode nCauseNode = CauseNodeList.Find(x => x.ID == m.ID);

                #region find upperlevel

                bool flagPre = false;

                List<string> PreCauseNodesIDlist = new List<string>();
                PreCauseNodesIDlist.AddRange(nCauseNode.PreCauselist);

                if (nCauseNode.PreCauselist.Count > 0)
                {
                    while (!flagPre)
                    {
                        //new is because previous one is already assigned to PreCauseNodesIDlist
                        List<string> buffFatherlist = new List<string>();
                        foreach (string aPreID in PreCauseNodesIDlist)
                        {
                            CauseNode aPreCauseNode = CauseNodeList.Find(x => x.ID == aPreID);
                            #region if the element in PreCauseNodesIDlist is found to be the one, update pre and next list, otherwise, update PreCauseNodesIDlist to buffFatherlist
                            if (FilteredCauseNodes.Find(x => x.ID == aPreID) != null)
                            {
                                flagPre = true;
                                if (!FilteredCauseNodes.Find(x => x.ID == aPreID).NextCauselist.Contains(m.ID))
                                {
                                    FilteredCauseNodes.Find(x => x.ID == aPreID).NextCauselist.Add(m.ID);
                                }
                                if (!FilteredCauseNodes.Find(x => x.ID == m.ID).PreCauselist.Contains(aPreID))
                                {
                                    FilteredCauseNodes.Find(x => x.ID == m.ID).PreCauselist.Add(aPreID);
                                }
                            }
                            else
                            {
                                if (aPreCauseNode.PreCauselist.Count == 0)
                                {
                                    flagPre = true;
                                }
                                else
                                {
                                    foreach (string s in aPreCauseNode.PreCauselist)
                                    {
                                        if (!buffFatherlist.Contains(s))
                                        {
                                            buffFatherlist.Add(s);
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        PreCauseNodesIDlist = buffFatherlist;
                    }
                }
                #endregion
                #region down level
                bool flagNex = false;
                List<string> NxtCauseNodeIDlist = new List<string>();
                NxtCauseNodeIDlist.AddRange(nCauseNode.NextCauselist);
                if (nCauseNode.NextCauselist.Count > 0)
                {
                    while (!flagNex)
                    {
                        List<string> bufflist = new List<string>();
                        foreach (string gcID in NxtCauseNodeIDlist)
                        {
                            CauseNode newFather = CauseNodeList.Find(x => x.ID == gcID);
                            #region similar as upper
                            if (FilteredCauseNodes.Find(x => x.ID == gcID) != null)
                            {
                                flagNex = true;
                                if (!FilteredCauseNodes.Find(x => x.ID == gcID).PreCauselist.Contains(m.ID))
                                {
                                    FilteredCauseNodes.Find(x => x.ID == gcID).PreCauselist.Add(m.ID);
                                }
                                if (!FilteredCauseNodes.Find(x => x.ID == m.ID).NextCauselist.Contains(gcID))
                                {
                                    FilteredCauseNodes.Find(x => x.ID == m.ID).NextCauselist.Add(gcID);
                                }
                            }
                            else
                            {
                                if (newFather.NextCauselist.Count == 0)
                                {
                                    flagNex = true;
                                }
                                else
                                {
                                    foreach (string s in newFather.NextCauselist)
                                    {
                                        if (!bufflist.Contains(s))
                                        {
                                            bufflist.Add(s);
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        NxtCauseNodeIDlist = bufflist;
                    }
                }
                #endregion

            }
            return FilteredCauseNodes;
        }

        public List<AuditTrailEntry> ReadXmlFileForATrace(string filePath)
        {
            List<AuditTrailEntry> ln = new List<AuditTrailEntry>();
            XmlReader reader = XmlReader.Create(filePath);
            int IDNum = 0;
            while (reader.ReadToFollowing("ProcessInstance") && reader.NodeType == XmlNodeType.Element)
            {

                while (reader.ReadToFollowing("AuditTrailEntry") && reader.NodeType == XmlNodeType.Element)
                {

                    AuditTrailEntry singleNode = new AuditTrailEntry();
                    //if (reader.Name == "AuditTrailEntry" && reader.NodeType == XmlNodeType.Element)
                    //{
                    reader.ReadSubtree();

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            switch (reader.Name)
                            {
                                case "WorkflowModelElement":

                                    // reader.ReadSubtree();
                                    reader.Read();
                                    string bfPar;
                                    bfPar = reader.Value;
                                    string newStr = bfPar.Replace("-","").Replace(' ', '_');
                                    singleNode.Name = newStr;
                                    break;
                                case "EventType":
                                    reader.ReadSubtree();
                                    reader.Read();
                                    singleNode.State = reader.Value;
                                    break;
                                default:
                                    break;
                            }
                        }
                        if (reader.Name == "EventType" && reader.NodeType == XmlNodeType.EndElement)
                        {
                            IDNum++;
                            break;
                        }
                    }
                    singleNode.ID = IDNum.ToString();
                    ln.Add(singleNode);
                }
            }
            return ln;
        }

        public List<ActionNode> FilteringCauseNodesForConformanceCheck(List<CauseNode> CauseNodeList)
        {
            List<ActionNode> FMarkingList = new List<ActionNode>();
            //List<CauseNode> FilteredCauseNodes = new List<CauseNode>();
            foreach (CauseNode m in CauseNodeList)
            {
                ActionNode newM;
                if (m.PreCauselist.Count == 0)
                {
                    newM = new ActionNode();
                    newM.ID = m.ID;
                    newM.Elment = m.ActivityEle;
                    FMarkingList.Add(newM);
                    continue;
                }
                bool flag = true;
                switch (m.ActivityEle.Type)
                {
                    case TypeOfElement.GateWay:
                    case TypeOfElement.IntermediateCatchEvent:
                    case TypeOfElement.IntermediateThrowEvent:
                    case TypeOfElement.Empty:
                    case TypeOfElement.EndEvent:
                    case TypeOfElement.StartEvent:
                    case TypeOfElement.BlockActivity:
                    case TypeOfElement.Sequence:
                        flag = false;
                        break;
                    case TypeOfElement.Task:
                        flag = true;
                        break;
                }
                if (flag)
                {
                    if (m.ruleName.Contains("enter"))
                    {
                        newM = new ActionNode();
                        newM.ID = m.ID;
                        newM.Elment = m.ActivityEle;
                        FMarkingList.Add(newM);
                        newM.Elment.State = "start";
                    }
                    else if (m.ruleName.Contains("leave") && !this.flagOnlyStart)
                    {
                        newM = new ActionNode();
                        newM.ID = m.ID;
                        newM.Elment = m.ActivityEle;
                        FMarkingList.Add(newM);
                        newM.Elment.State = "complete";
                    }
                }

            }

            foreach (ActionNode m in FMarkingList)
            {
                List<string> mFather = FindParent(m.ID, CauseNodeList, FMarkingList);
                foreach (string mFID in mFather)
                {
                    if (!FMarkingList.Find(x => x.ID == mFID).NextMarkingIDlist.Contains(m.ID))
                    {
                        FMarkingList.Find(x => x.ID == mFID).NextMarkingIDlist.Add(m.ID);
                    }
                    if (!FMarkingList.Find(x => x.ID == m.ID).PreMarkingIDlist.Contains(mFID))
                    {
                        FMarkingList.Find(x => x.ID == m.ID).PreMarkingIDlist.Add(mFID);
                    }

                }
                List<string> mChild = FindChild(m.ID, CauseNodeList, FMarkingList);
                foreach (string mCID in mChild)
                {
                    if (!FMarkingList.Find(x => x.ID == mCID).PreMarkingIDlist.Contains(m.ID))
                    {
                        FMarkingList.Find(x => x.ID == mCID).PreMarkingIDlist.Add(m.ID);
                    }
                    if (!FMarkingList.Find(x => x.ID == m.ID).NextMarkingIDlist.Contains(mCID))
                    {
                        FMarkingList.Find(x => x.ID == m.ID).NextMarkingIDlist.Add(mCID);
                    }

                }
            }
            //Here we can add a part to add layer information
            #region adding layer information
            int curNodeIndex = FMarkingList.FindIndex(delegate(ActionNode a) { return a.PreMarkingIDlist.Count == 0; });
            FMarkingList[curNodeIndex].Layer = 0;
            List<List<string>> layerInfoMatrix = new List<List<string>>();
            layerInfoMatrix.Add(FMarkingList[curNodeIndex].NextMarkingIDlist);
            int imaxLayer = 0;
            for (; ; imaxLayer++)
            {
                List<string> tobeList = new List<string>();
                if (layerInfoMatrix[imaxLayer].Count > 0)
                {
                    foreach (string s in layerInfoMatrix[imaxLayer])
                    {
                        curNodeIndex = FMarkingList.FindIndex(delegate(ActionNode a) { return a.ID == s; });
                        FMarkingList[curNodeIndex].Layer = imaxLayer + 1;
                    }
                    foreach (string s in layerInfoMatrix[imaxLayer])
                    {
                        curNodeIndex = FMarkingList.FindIndex(delegate(ActionNode a) { return a.ID == s; });
                        //FMarkingList[curNodeIndex].Layer = curLayer + 1;
                        foreach (string tobeNode in FMarkingList[curNodeIndex].NextMarkingIDlist)
                        {
                            if (FMarkingList.Find(x => x.ID == tobeNode).Layer == 0 || FMarkingList.Find(x => x.ID == tobeNode).Layer > imaxLayer + 1)
                            {
                                tobeList.Add(tobeNode);
                            }
                        }

                        List<string> tobeListDis = tobeList.Distinct().ToList();
                        tobeList = tobeListDis;
                    }

                    layerInfoMatrix.Add(tobeList);
                }
                else
                    break;
            }
            #endregion


            return FMarkingList;
        }

        public List<ActionNode> FilteringCauseNodesForConformanceCheck(List<CauseNode> CauseNodeList, List<string> ActivityNameInScope)
        {
            List<ActionNode> FMarkingList = new List<ActionNode>();
            //List<CauseNode> FilteredCauseNodes = new List<CauseNode>();
            foreach (CauseNode m in CauseNodeList)
            {

                if (m.PreCauselist.Count == 0)
                {
                    ActionNode newM = new ActionNode();
                    newM.ID = m.ID;
                    newM.Elment = m.ActivityEle;
                    FMarkingList.Add(newM);
                    continue;
                }
                bool flag = true;
                switch (m.ActivityEle.Type)
                {
                    case TypeOfElement.GateWay:
                    case TypeOfElement.IntermediateCatchEvent:
                    case TypeOfElement.IntermediateThrowEvent:
                    case TypeOfElement.Empty:
                    case TypeOfElement.EndEvent:
                    case TypeOfElement.StartEvent:
                    case TypeOfElement.BlockActivity:
                    case TypeOfElement.Sequence:
                        flag = false;
                        break;
                    case TypeOfElement.Task:                   
                        flag = true;
                        break;
                }
                if (flag && ActivityNameInScope.Contains(m.ActivityEle.Name))
                {
                    if (m.ruleName.Contains("enter"))
                    {
                        ActionNode newM = new ActionNode();
                        newM.ID = m.ID;
                        newM.Elment = m.ActivityEle;
                        FMarkingList.Add(newM);
                        newM.Elment.State = "start";
                    }
                    else if (m.ruleName.Contains("leave") && !flagOnlyStart)
                    {
                        ActionNode newM = new ActionNode();
                        newM.ID = m.ID;
                        newM.Elment = m.ActivityEle;
                        FMarkingList.Add(newM);
                        newM.Elment.State = "complete";
                    }
                }

            }

            foreach (ActionNode m in FMarkingList)
            {
                List<string> mFather = FindParent(m.ID, CauseNodeList, FMarkingList);
                foreach (string mFID in mFather)
                {
                    if (!FMarkingList.Find(x => x.ID == mFID).NextMarkingIDlist.Contains(m.ID))
                    {
                        FMarkingList.Find(x => x.ID == mFID).NextMarkingIDlist.Add(m.ID);
                    }
                    if (!FMarkingList.Find(x => x.ID == m.ID).PreMarkingIDlist.Contains(mFID))
                    {
                        FMarkingList.Find(x => x.ID == m.ID).PreMarkingIDlist.Add(mFID);
                    }

                }
                List<string> mChild = FindChild(m.ID, CauseNodeList, FMarkingList);
                foreach (string mCID in mChild)
                {
                    if (!FMarkingList.Find(x => x.ID == mCID).PreMarkingIDlist.Contains(m.ID))
                    {
                        FMarkingList.Find(x => x.ID == mCID).PreMarkingIDlist.Add(m.ID);
                    }
                    if (!FMarkingList.Find(x => x.ID == m.ID).NextMarkingIDlist.Contains(mCID))
                    {
                        FMarkingList.Find(x => x.ID == m.ID).NextMarkingIDlist.Add(mCID);
                    }

                }
            }
            //Here we can add a part to add layer information
            #region adding layer information
            int curNodeIndex = FMarkingList.FindIndex(delegate(ActionNode a) { return a.PreMarkingIDlist.Count == 0; });
            FMarkingList[curNodeIndex].Layer = 0;
            List<List<string>> layerInfoMatrix = new List<List<string>>();
            layerInfoMatrix.Add(FMarkingList[curNodeIndex].NextMarkingIDlist);
            int imaxLayer = 0;
            for (; ; imaxLayer++)
            {
                List<string> tobeList = new List<string>();
                if (layerInfoMatrix[imaxLayer].Count > 0)
                {
                    foreach (string s in layerInfoMatrix[imaxLayer])
                    {
                        curNodeIndex = FMarkingList.FindIndex(delegate(ActionNode a) { return a.ID == s; });
                        FMarkingList[curNodeIndex].Layer = imaxLayer + 1;
                    }
                    foreach (string s in layerInfoMatrix[imaxLayer])
                    {
                        curNodeIndex = FMarkingList.FindIndex(delegate(ActionNode a) { return a.ID == s; });
                        //FMarkingList[curNodeIndex].Layer = curLayer + 1;
                        foreach (string tobeNode in FMarkingList[curNodeIndex].NextMarkingIDlist)
                        {
                            if (FMarkingList.Find(x => x.ID == tobeNode).Layer == 0 || FMarkingList.Find(x => x.ID == tobeNode).Layer > imaxLayer + 1)
                            {
                                tobeList.Add(tobeNode);
                            }
                        }

                        List<string> tobeListDis = tobeList.Distinct().ToList();
                        tobeList = tobeListDis;
                    }

                    layerInfoMatrix.Add(tobeList);
                }
                else
                    break;
            }
            #endregion


            return FMarkingList;
        }
        //private List<List<AMatch>> GetAllAlignmentResults(List<AMatch> MatchTree, List<AMatch> listLeafMatch)
        //{
        //    List<List<AMatch>> alignmentTable = new List<List<AMatch>>();
        //    IEnumerable<AMatch> orderedLeafOnDeviations = listLeafMatch.OrderByDescending((n => n.Deviations));
        //    int lowestDeviation = orderedLeafOnDeviations.ToArray()[0].Deviations;

        //    List<AMatch> listOfOptiLeaf = listLeafMatch.FindAll(x => x.Deviations == lowestDeviation);

        //    for (int j = 0; j < listOfOptiLeaf.Count; j++)
        //    {
        //        List<AMatch> bestAlignment = new List<AMatch>();

        //        AMatch OptiLeaf = listOfOptiLeaf[j];
        //        while (OptiLeaf != null)
        //        {
        //            bestAlignment.Add(OptiLeaf);
        //            OptiLeaf = OptiLeaf.PreMatch;
        //        }
        //        alignmentTable.Add(bestAlignment);
        //    }
        //    return alignmentTable;
        //}
        private List<string> FindParent(string curID, List<CauseNode> CauseNodeList, List<ActionNode> FMarkingList)
        {
            List<string> FatherIDList = new List<string>();
            CauseNode curCauseNode = CauseNodeList.Find(x => x.ID == curID);

            #region find upperlevel
            Queue<string> PreCauseNodesIDlist = new Queue<string>();
            foreach (string s in curCauseNode.PreCauselist)
            {
                PreCauseNodesIDlist.Enqueue(s);
            }

            while (PreCauseNodesIDlist.Count != 0)
            {
                string aPreID = PreCauseNodesIDlist.Dequeue();
                //new is because previous one is already assigned to PreCauseNodesIDlist
                //Queue<string> buffFatherlist = new Queue<string>();

                CauseNode aPreCauseNode = CauseNodeList.Find(x => x.ID == aPreID);

                bool flagPre = false;
                if (FMarkingList.Find(x => x.ID == aPreID) != null)
                {
                    flagPre = true;
                    FatherIDList.Add(aPreID);
                    //break;
                }
                else
                {
                    if (aPreCauseNode.PreCauselist.Count == 0)
                    {
                        flagPre = true;
                    }
                    else
                    {
                        foreach (string s in aPreCauseNode.PreCauselist)
                        {
                            if (!PreCauseNodesIDlist.Contains(s))
                            {
                                PreCauseNodesIDlist.Enqueue(s);
                            }
                        }
                    }
                }
            }
            #endregion
            return FatherIDList;
        }
        private List<string> FindChild(string curID, List<CauseNode> CauseNodeList, List<ActionNode> FMarkingList)
        {
            List<string> ChildIDList = new List<string>();
            CauseNode curCauseNode = CauseNodeList.Find(x => x.ID == curID);

            #region find downlevel
            Queue<string> NextCauseNodesIDlist = new Queue<string>();
            foreach (string s in curCauseNode.NextCauselist)
            {
                NextCauseNodesIDlist.Enqueue(s);
            }

            while (NextCauseNodesIDlist.Count != 0)
            {
                string aNextID = NextCauseNodesIDlist.Dequeue();
                //new is because previous one is already assigned to PreCauseNodesIDlist
                //Queue<string> buffFatherlist = new Queue<string>();

                CauseNode aNextCauseNode = CauseNodeList.Find(x => x.ID == aNextID);

                bool flagNext = false;
                if (FMarkingList.Find(x => x.ID == aNextID) != null)
                {
                    flagNext = true;
                    ChildIDList.Add(aNextID);
                    //break;
                }
                else
                {
                    if (aNextCauseNode.PreCauselist.Count == 0)
                    {
                        flagNext = true;
                    }
                    else
                    {
                        foreach (string s in aNextCauseNode.NextCauselist)
                        {
                            if (!NextCauseNodesIDlist.Contains(s))
                            {
                                NextCauseNodesIDlist.Enqueue(s);
                            }
                        }
                    }
                }
            }
            #endregion

            return ChildIDList;
        }
        private List<AuditTrailEntry> FilteringAuditEntiesForConformanceCheck(List<AuditTrailEntry> originalList, List<string> lognames)
        {
            List<AuditTrailEntry> filteredEntrylist = new List<AuditTrailEntry>();
            foreach (var entry in originalList)
            {
                if (lognames.Contains(entry.Name))
                {
                    filteredEntrylist.Add(entry);
                }
            }
            return filteredEntrylist;
        }

        private List<ActionNode> MaxXYDev(List<ActionNode> originalLsActionNodes, out int maxLayerDevXY)
        {
            //           
            //int curNodeIndex = originalLsActionNodes.FindIndex(delegate(ActionNode a) { return a.PreMarkingIDlist.Count == 0; });            
            //ActionNode curAMatch = originalLsActionNodes[curNodeIndex];
            //List<List<ActionNode>> NodeSetList = this.FindSubPaths(curAMatch, originalLsActionNodes);

            //foreach (var node in NodeSetList)
            //{
            //    node.Reverse();
            //}
            //foreach(ActionNode nodel in originalLsActionNodes)
            //{
            //    nodel.Layer=MaxNodeIndex(nodel.ID,NodeSetList);
            //}

            maxLayerDevXY = 0;
            int maxLayerX = 0;
            int maxLayerY = 0;
            foreach (ActionNode nodel in originalLsActionNodes)
            {
                int fatherLayer = nodel.Layer;
                foreach(string childID in nodel.NextMarkingIDlist)
                {
                    int childLayer=originalLsActionNodes.Find(x=>x.ID==childID).Layer;
                    int layerDev=childLayer - fatherLayer;
                    if (layerDev > maxLayerY)
                    {
                        maxLayerY = layerDev;
                    }
                    if (layerDev < maxLayerX)
                    {
                        maxLayerX = layerDev;
                    }
                }
            }
            maxLayerDevXY = maxLayerY - maxLayerX;
            return originalLsActionNodes;
        }
        private List<List<ActionNode>> FindSubPaths(ActionNode curNode,List<ActionNode> originallist, List<string> passedNodeList = null)
        {
            if (passedNodeList == null)
            {
                passedNodeList = new List<string>();
                passedNodeList.Add(curNode.ID);
            }
            else
            {
                passedNodeList.Add(curNode.ID);
            }

            if (curNode.NextMarkingIDlist != null && curNode.NextMarkingIDlist.Count > 0)
            {
                List<List<ActionNode>> outputNodeSetList = new List<List<ActionNode>>();
                foreach (var childID in curNode.NextMarkingIDlist)
                {
                    if (passedNodeList.Exists(n => n == childID) && passedNodeList.IndexOf(childID) < passedNodeList.IndexOf(curNode.ID))
                    {
                        if (curNode.NextMarkingIDlist.Count == 1)
                        {
                            List<ActionNode> nodeList = new List<ActionNode>();
                            nodeList.Add(curNode);
                            List<List<ActionNode>> pnodeSetList = new List<List<ActionNode>>();
                            pnodeSetList.Add(nodeList);

                            return pnodeSetList;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    ActionNode newNode = originallist.Find(x => x.ID == childID);
                    List<List<ActionNode>> nodeSetList = this.FindSubPaths(newNode,originallist, passedNodeList);
                    foreach (var nodeList in nodeSetList)
                    {
                        nodeList.Add(curNode);
                    }

                    outputNodeSetList.AddRange(nodeSetList);
                }

                return outputNodeSetList;
            }
            else
            {
                passedNodeList.Remove(curNode.ID);
                List<ActionNode> nodeList = new List<ActionNode>();
                nodeList.Add(curNode);
                List<List<ActionNode>> nodeSetList = new List<List<ActionNode>>();
                nodeSetList.Add(nodeList);

                return nodeSetList;
            }
        }
        public int MaxNodeIndex(string nodeName,List<List<ActionNode>> NodeSetList)
        {
            int maxLength = 0;
            foreach (var nodeSet in NodeSetList)
            {
                int length = nodeSet.FindIndex(ns => ns.ID == nodeName);
                maxLength = maxLength > length ? maxLength : length;
            }

            return maxLength + 1;
        }
        public List<AMatch> ConstructTheMatchTree(List<ActionNode> _lsModel, List<AuditTrailEntry> _lsEntry, out List<AMatch> LeafMatches)
        {
            //MatchesTree is the result of alignment, it stores all the possible paths as a tree
            List<AMatch> MatchesTree = new List<AMatch>();            

            //TailMatchSet is an intermediate during constructing the MatchesTree 
            List<AMatch> TailMatchSet = new List<AMatch>();

            LeafMatches = new List<AMatch>();

            List<ActionNode> curMarkingSet = new List<ActionNode>();
            AuditTrailEntry curEntry = new AuditTrailEntry();
            //Add the empty match into TailMatchSet
            //once a new instance of AMatch contains instances of Entry and TaskMarking
            AMatch firstMatch = new AMatch();
            firstMatch.Cost = 0;
            firstMatch.Deviations = 0;
            firstMatch.Layer = 0;

            firstMatch.Entry.ID = "";
            firstMatch.TaskMarking.ID = "";

            int MatchID = 0;
            TailMatchSet.Add(firstMatch);
            MatchesTree.Add(firstMatch);

            

            while (TailMatchSet.Count >0)
            {               
            
                #region exploration of tree
                int loOfCurEntry;
                int loOfCurEleInMdl;
                int heurisValueLogPart;
                int heurisValueModelPart;
                //int heurisValue;

                bool labelStop = false;

                #region Finding the lowest cost set
                //Get those with GlobalLowestDevs global least deviations from the TailMatchlist as current AMatch to extend                  
                double GlobalLowestDevs = TailMatchSet.Min(AMatch => AMatch.Cost);

                List<AMatch> LowestDevMatches = new List<AMatch>();

                for (int i = 0; i < TailMatchSet.Count; i++)
                {
                    //labelStop = false;
                    AMatch OneMatch = TailMatchSet[i];
                    if (OneMatch.Cost == GlobalLowestDevs)
                    {
                        LowestDevMatches.Add(OneMatch);
                        TailMatchSet.Remove(OneMatch);
                        i--;
                    }
                    if (EndOfLog(OneMatch.Entry, _lsEntry) && EndOfStatespace(OneMatch.TaskMarking))
                    {
                        labelStop = true;
                        LeafMatches.Add(OneMatch);
                    }
                }

                if (labelStop == true)
                {
                    //MessageBox.Show("Finished!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    //this.btn_show.IsEnabled = true;
                    //this.ShowGraph();
                    break;
                }
                
                #endregion
                //List<AMatch> ToJoinList = new List<AMatch>();
                foreach (AMatch FatherMatch in LowestDevMatches)
                {
                    bool labelEndOfModel = false;
                    bool labelEndOfLog = false;

                    if (EndOfLog(FatherMatch.Entry, _lsEntry))
                    {
                        labelEndOfLog = true;
                    }
                    if (EndOfStatespace(FatherMatch.TaskMarking))
                    {
                        labelEndOfModel = true;
                    }
                    #region neither end
                    if (labelEndOfModel == false && labelEndOfLog == false)
                    {
                        #region preparing model and log
                        if (FatherMatch.MatchType == TypeOfMatch.NotMatched)
                        {
                            int indexOfFirst = _lsModel.FindIndex(x => x.PreMarkingIDlist.Count == 0);
                            ActionNode ActionNodeStart = _lsModel[indexOfFirst];

                            curMarkingSet = FindTheChildMarkingSet(ActionNodeStart,_lsModel);

                            curEntry = _lsEntry[0];
                        }
                        else
                        {
                            //???
                            if (FatherMatch.TaskMarking == null)
                            {
                                int indexOfFirst = _lsModel.FindIndex(x => x.PreMarkingIDlist.Count == 0);
                                ActionNode ActionNodeStart = _lsModel[indexOfFirst];
                                curMarkingSet = FindTheChildMarkingSet(ActionNodeStart, _lsModel);
                            }
                            else
                            {

                                curMarkingSet = FindTheChildMarkingSet(FatherMatch.TaskMarking, _lsModel);
                            }
                            //???
                            if (FatherMatch.Entry == null)
                            {
                                curEntry = _lsEntry[0];
                            }
                            else
                            {
                                curEntry = FindNextEntry(FatherMatch.Entry, _lsEntry);
                            }
                        }
                        #endregion
                        //int InxBcCun = curMarkingSet.FindIndex(x => (x.Elment.Name == curEntry.Name) && (x.Elment.State == curEntry.State));
                        List<ActionNode> matchedMarkings = curMarkingSet.FindAll(x => (x.Elment.Name == curEntry.Name) && (x.Elment.State == curEntry.State));
                        //if (InxBcCun > -1)
                        if (matchedMarkings.Count>0)
                        {
                            for (int InxBcCun = 0; InxBcCun < matchedMarkings.Count; InxBcCun++)
                            {
                                #region bothcorrect amatch adding
                                loOfCurEntry = _lsEntry.FindIndex(x => x.ID == curEntry.ID);
                                heurisValueLogPart = _lsEntry.Count - loOfCurEntry;

                                loOfCurEleInMdl = FindRemainingStepNumInModel(matchedMarkings[InxBcCun], _lsModel);
                                heurisValueModelPart = loOfCurEleInMdl;
                                //heurisValue = (heurisValueLogPart + heurisValueModelPart) / 2;
                                //heurisValue = Math.Max(heurisValueLogPart, heurisValueModelPart);
                                //heurisValue = heurisValueLogPart + heurisValueModelPart;

                                AMatch BcMatch = new AMatch();

                                BcMatch.Deviations = FatherMatch.Deviations;
                                //BcMatch.Cost = BcMatch.Deviations + heurisValue;
                                //BcMatch.Cost = FatherMatch.Cost;                
                                BcMatch.Cost = HeurisValue(heurisValueLogPart, heurisValueModelPart) + BcMatch.Deviations;
                                BcMatch.Layer = FatherMatch.Layer + 1;
                                BcMatch.MatchType = TypeOfMatch.BothCorrect;
                                BcMatch.TaskMarking = matchedMarkings[InxBcCun];
                                BcMatch.Entry = curEntry;
                                //Previous version is only combine nodes who generated at the same time, now we changed into a new version where newly added node combined with a node in the existing tree.
                                //int joinedId = ToJoinList.FindIndex(x => (BcMatch.TaskMarking.Layer == x.TaskMarking.Layer) && (BcMatch.Entry.ID == x.Entry.ID));
                                int IDinTree = MatchesTree.FindIndex(x => (BcMatch.TaskMarking.ID == x.TaskMarking.ID) && (BcMatch.Entry.ID == x.Entry.ID) && (x.MatchType == TypeOfMatch.BothCorrect) && (x.Deviations == BcMatch.Deviations) && (x.Cost == BcMatch.Cost));
                                //if (joinedId > -1)
                                if (IDinTree > -1)
                                {
                                    //int wholeID = MatchesTree.FindIndex(x => x.ID == ToJoinList[joinedId].ID);
                                    //MatchesTree[wholeID].PreMatch.Add(FatherMatch);
                                    MatchesTree[IDinTree].PreMatch.Add(FatherMatch);
                                }
                                else
                                {
                                    BcMatch.PreMatch.Add(FatherMatch);
                                    MatchID++;
                                    BcMatch.ID = MatchID;

                                    TailMatchSet.Add(BcMatch);
                                    MatchesTree.Add(BcMatch);
                                }
                                #endregion
                            }
                        }
                        else
                        {
                            #region fake task correct entry
                            loOfCurEntry = _lsEntry.FindIndex(x => x.ID == curEntry.ID);
                            heurisValueLogPart = _lsEntry.Count - loOfCurEntry;
                            if (FatherMatch.TaskMarking == null)
                            {
                                int indexOfStartEvent = _lsModel.FindIndex(x => x.Elment.Type == TypeOfElement.StartEvent);
                                ActionNode MarkingStart = _lsModel[indexOfStartEvent];
                                loOfCurEleInMdl = FindRemainingStepNumInModel(MarkingStart, _lsModel);
                            }
                            else
                            {
                                loOfCurEleInMdl = FindRemainingStepNumInModel(FatherMatch.TaskMarking, _lsModel);
                            }

                            heurisValueModelPart = loOfCurEleInMdl;
                            //int heurisValue=(heurisValueLogPart+heurisValueModelPart)/2;
                            //heurisValue = (heurisValueLogPart + heurisValueModelPart) / 2;
                            //heurisValue = Math.Max(heurisValueLogPart, heurisValueModelPart);
                            //heurisValue = heurisValueLogPart + heurisValueModelPart;

                            //MatchID++;
                            AMatch FTaskCEntry = new AMatch();

                            FTaskCEntry.Deviations = FatherMatch.Deviations + 1;
                            //FTaskCEntry.Cost = FTaskCEntry.Deviations + heurisValue;
                            FTaskCEntry.Cost = HeurisValue(heurisValueLogPart, heurisValueModelPart) + FTaskCEntry.Deviations;
                            //FTaskCEntry.Cost = FatherMatch.Cost + 1 + listEntries.Count - loOfCur;
                            //FTaskCEntry.Cost = FatherMatch.Cost + 1;

                            FTaskCEntry.Layer = FatherMatch.Layer + 1;
                            FTaskCEntry.MatchType = TypeOfMatch.FTaskCEntry;
                            //FTaskCEntry.PreMatch.Add(FatherMatch);
                            FTaskCEntry.TaskMarking = FatherMatch.TaskMarking;
                            FTaskCEntry.Entry = curEntry;
                            //FTaskCEntry.ID = MatchID;
                            //TailMatchSet.Add(FTaskCEntry);
                            //MatchesTree.Add(FTaskCEntry);

                            int IDinTree = MatchesTree.FindIndex(x => (FTaskCEntry.TaskMarking.ID == x.TaskMarking.ID) && (FTaskCEntry.Entry.ID == x.Entry.ID) && (FTaskCEntry.Cost == x.Cost));

                            if (IDinTree > -1)
                            {
                                if (MatchesTree[IDinTree].MatchType == TypeOfMatch.FTaskCEntry || MatchesTree[IDinTree].MatchType == TypeOfMatch.BothFake)
                                {
                                    MatchesTree[IDinTree].PreMatch.Add(FatherMatch);
                                }
                                else if (MatchesTree[IDinTree].MatchType == TypeOfMatch.CTaskFEntry)
                                {
                                    MatchesTree[IDinTree].MatchType = TypeOfMatch.BothFake;
                                    MatchesTree[IDinTree].PreMatch.Add(FatherMatch);
                                    int IDinTail = TailMatchSet.FindIndex(x => x.ID == MatchesTree[IDinTree].ID);
                                    if (IDinTail > -1)
                                    {
                                        TailMatchSet[IDinTail].MatchType = TypeOfMatch.BothFake;
                                    }
                                }
                                //Is it a problem that we only update MatchesTree while leaves TailMatchSet behind? No, because we do not make use of PreMatch.                                
                            }
                            else
                            {
                                FTaskCEntry.PreMatch.Add(FatherMatch);
                                MatchID++;
                                FTaskCEntry.ID = MatchID;

                                TailMatchSet.Add(FTaskCEntry);
                                MatchesTree.Add(FTaskCEntry);
                            }
                            #endregion
                        }
                        List<ActionNode> remainingSet = new List<ActionNode>();
                        //remainingSet = (curMarkingSet.Except(matchedMarkings) as List<ActionNode>);
                        foreach (var action in curMarkingSet)
                        {
                            if (!matchedMarkings.Contains(action))
                            {
                                remainingSet.Add(action);
                            }
                        }
                        
                        for (int i = 0; i < remainingSet.Count; i++)
                        {
                            //if (i != InxBcCun)
                            //{
                            #region correct task fake entry
                            //if (curMarkingSet[i].Layer > FatherMatch.TaskMarking.Layer || (curMarkingSet[i].Layer == FatherMatch.TaskMarking.Layer && IndeedLoop(curMarkingSet[i], FatherMatch.TaskMarking, this._lsModel)))
                            //{
                            //bug if fatherMatch.Entry.ID is null
                            loOfCurEntry = _lsEntry.FindIndex(x => x.ID == FatherMatch.Entry.ID);
                            //added Oct. 6th, to have length of model also involved.
                            heurisValueLogPart = _lsEntry.Count - loOfCurEntry;

                            loOfCurEleInMdl = FindRemainingStepNumInModel(curMarkingSet[i], _lsModel);
                            heurisValueModelPart = loOfCurEleInMdl;
                            //heurisValue = (heurisValueLogPart + heurisValueModelPart) / 2;
                            //heurisValue = Math.Max(heurisValueLogPart, heurisValueModelPart);
                            //heurisValue = heurisValueLogPart + heurisValueModelPart;

                            //MatchID++;
                            AMatch CTaskFEntry = new AMatch();

                            CTaskFEntry.Deviations = FatherMatch.Deviations + 1;
                            //CTaskFEntry.Cost = CTaskFEntry.Deviations + heurisValue;
                            CTaskFEntry.Cost = HeurisValue(heurisValueLogPart, heurisValueModelPart) + CTaskFEntry.Deviations;
                            //CTaskFEntry.Cost = FatherMatch.Cost + 1 + listEntries.Count - loOfCur;
                            //CTaskFEntry.Cost = FatherMatch.Cost + 1;
                            CTaskFEntry.Layer = FatherMatch.Layer + 1;
                            CTaskFEntry.MatchType = TypeOfMatch.CTaskFEntry;
                            //CTaskFEntry.PreMatch.Add(FatherMatch);
                            CTaskFEntry.TaskMarking = curMarkingSet[i];
                            CTaskFEntry.Entry = FatherMatch.Entry;
                            //CTaskFEntry.ID = MatchID;
                            //TailMatchSet.Add(CTaskFEntry);
                            //LabelMatched = true;
                            //MatchesTree.Add(CTaskFEntry);

                            int IDinTree = MatchesTree.FindIndex(x => (CTaskFEntry.TaskMarking.ID == x.TaskMarking.ID) && (CTaskFEntry.Entry.ID == x.Entry.ID) && (CTaskFEntry.Cost == x.Cost));

                            if (IDinTree > -1)
                            {
                                if (MatchesTree[IDinTree].MatchType == TypeOfMatch.CTaskFEntry || MatchesTree[IDinTree].MatchType == TypeOfMatch.BothFake)
                                {
                                    MatchesTree[IDinTree].PreMatch.Add(FatherMatch);
                                }
                                else if (MatchesTree[IDinTree].MatchType == TypeOfMatch.FTaskCEntry)
                                {
                                    MatchesTree[IDinTree].MatchType = TypeOfMatch.BothFake;
                                    MatchesTree[IDinTree].PreMatch.Add(FatherMatch);
                                    int IDinTail = TailMatchSet.FindIndex(x => x.ID == MatchesTree[IDinTree].ID);
                                    if (IDinTail > -1)
                                    {
                                        TailMatchSet[IDinTail].MatchType = TypeOfMatch.BothFake;
                                    }
                                }
                                //Is it a problem that we only update MatchesTree while leaves TailMatchSet behind? No, because we do not make use of PreMatch.                                
                            }
                            else
                            {
                                CTaskFEntry.PreMatch.Add(FatherMatch);
                                MatchID++;
                                CTaskFEntry.ID = MatchID;

                                TailMatchSet.Add(CTaskFEntry);
                                MatchesTree.Add(CTaskFEntry);
                            }
                            //}
                            #endregion
                            //}
                        }
                        
                    }
                    #endregion
                    #region end of model
                    else if (labelEndOfLog == false && labelEndOfModel == true)
                    {
                        MatchID++;
                        AMatch FTaskCEntry = new AMatch();
                        if (FatherMatch.Entry == null)
                        {
                            curEntry = _lsEntry[0];
                        }
                        else
                        {
                            curEntry = FindNextEntry(FatherMatch.Entry, _lsEntry);
                        }
                        loOfCurEntry = _lsEntry.FindIndex(x => x.ID == curEntry.ID);
                        heurisValueLogPart = _lsEntry.Count - loOfCurEntry;
                        //heurisValue = (heurisValueLogPart) / 2;
                        //heurisValue = heurisValueLogPart;

                        //heurisValue = heurisValueLogPart;

                        FTaskCEntry.Deviations = FatherMatch.Deviations + 1;
                        FTaskCEntry.Cost = HeurisValue(heurisValueLogPart, 0) + FTaskCEntry.Deviations;
                        //FTaskCEntry.Cost = FTaskCEntry.Deviations + heurisValue;
                        //FTaskCEntry.Cost = FatherMatch.Cost + 1;
                        //FTaskCEntry.Cost = FatherMatch.Cost + 1 + listEntries.Count - loOfCur;
                        FTaskCEntry.Layer = FatherMatch.Layer + 1;

                        FTaskCEntry.MatchType = TypeOfMatch.FTaskCEntry;
                        FTaskCEntry.PreMatch.Add(FatherMatch);
                        FTaskCEntry.TaskMarking = FatherMatch.TaskMarking;
                        //Special,there it is end of model match the next entry from current phase while match the marking as the same with father match.
                        FTaskCEntry.Entry = curEntry;


                        FTaskCEntry.ID = MatchID;
                        TailMatchSet.Add(FTaskCEntry);

                        MatchesTree.Add(FTaskCEntry);
                    }
                    #endregion
                    #region end of log
                    else if (labelEndOfModel == false && labelEndOfLog == true)
                    {
                        if (FatherMatch.TaskMarking == null)
                        {
                            int indexOfStartEvent = _lsModel.FindIndex(x => x.Elment.Type == TypeOfElement.StartEvent);
                            ActionNode MarkingStart = _lsModel[indexOfStartEvent];
                            curMarkingSet = FindTheChildMarkingSet(MarkingStart, _lsModel);
                        }
                        else
                        {
                            curMarkingSet = FindTheChildMarkingSet(FatherMatch.TaskMarking, _lsModel);
                        }

                        for (int i = 0; i < curMarkingSet.Count; i++)
                        {
                            loOfCurEleInMdl = FindRemainingStepNumInModel(curMarkingSet[i], _lsModel);
                            heurisValueModelPart = loOfCurEleInMdl;
                            //heurisValue = (heurisValueModelPart) / 2;
                            //heurisValue = heurisValueModelPart;

                            MatchID++;
                            AMatch CTaskFEntry = new AMatch();

                            CTaskFEntry.Deviations = FatherMatch.Deviations + 1;
                            CTaskFEntry.Cost = HeurisValue(0, heurisValueModelPart) + CTaskFEntry.Deviations;
                            //CTaskFEntry.Cost = CTaskFEntry.Deviations + heurisValue;
                            //CTaskFEntry.Cost = FatherMatch.Cost + 1 + listEntries.Count - loOfCur;
                            //CTaskFEntry.Cost = FatherMatch.Cost + 1;
                            CTaskFEntry.Layer = FatherMatch.Layer + 1;
                            CTaskFEntry.MatchType = TypeOfMatch.CTaskFEntry;
                            CTaskFEntry.PreMatch.Add(FatherMatch);
                            CTaskFEntry.TaskMarking = curMarkingSet[i];
                            CTaskFEntry.Entry = FatherMatch.Entry;
                            CTaskFEntry.ID = MatchID;

                            TailMatchSet.Add(CTaskFEntry);
                            MatchesTree.Add(CTaskFEntry);
                        }
                    }
                    #endregion
                }
                #endregion                
            }     
            return MatchesTree;
        }

        protected double HeurisValue(double heuL, double heuM)
        {
            double heuV;
            heuV = heuL + heuM;
            return heuV * this.dynamicParameter;
        }
        //private List<ActionNode> FindTheGraChildMarkingSet(ActionNode mGr)
        //{
        //    List<ActionNode> listOfChildMarking = new List<ActionNode>();
        //    List<string> listGraMarking = new List<string>();
        //    foreach (string mfStr in mGr.NextMarkingIDlist)
        //    {
        //        int index = _lsModel.FindIndex(x => x.ID == mfStr);
        //        if (index >= 0)
        //        {
        //            listOfChildMarking.Add(this._lsModel[index]);
        //            listGraMarking.AddRange(this._lsModel[index].NextMarkingIDlist);
        //        }
        //    }
        //    List<ActionNode> listOfStruGra = new List<ActionNode>();
        //    IEnumerable<string> listGraMarking1 = listGraMarking.Distinct();
        //    foreach (string chstr in listGraMarking1)
        //    {
        //        int index = this._lsModel.FindIndex(x => x.ID == chstr);
        //        if (index >= 0)
        //        {
        //            listOfStruGra.Add(this._lsModel[index]);
        //        }
        //    }
        //    return listOfStruGra;
        //}
        public int FindRemainingStepNumInModel(ActionNode FatherElement, List<ActionNode> originalList)
        {
            //int indOfloOfTaskMarking = 0;
            //indOfloOfTaskMarking = (int)CountAveragePathLength(FatherElement, originalList);    
            IEnumerable<ActionNode> orderedNodeSetList = originalList.OrderByDescending(n => n.Layer);
            int maxlayer = orderedNodeSetList.ToArray()[0].Layer;

            return maxlayer - FatherElement.Layer;
        }
        private bool EndOfLog(AuditTrailEntry en, List<AuditTrailEntry> listEntries)
        {
            bool endOfTrace = false;
            //if (en != null)
            if (en.ID != "")
            {
                if (FindNextEntry(en, listEntries).ID == null)
                {
                    endOfTrace = true;
                }
            }
            return endOfTrace;
        }
        private bool EndOfStatespace(ActionNode strMk)
        {
            bool endOfModel = false;
            if (strMk.ID != "")
            //if (strMk != null)
            {
                if (strMk.NextMarkingIDlist.Count == 0)
                {
                    endOfModel = true;
                }
            }
            return endOfModel;
        }
        private bool IndeedLoop(ActionNode curMarking, ActionNode fatherMarking, List<ActionNode> listStruMarkings)
        {
            bool flag = false;
            foreach (var s in fatherMarking.NextMarkingIDlist)
            {
                string matched = curMarking.PreMarkingIDlist.Find(x => x == s);
                if (matched != null)
                {
                    ActionNode matchedMarking = listStruMarkings.Find(x => x.ID == matched);
                    if (matchedMarking.Layer < fatherMarking.Layer)
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }
        private AuditTrailEntry FindNextEntry(AuditTrailEntry faEntry, List<AuditTrailEntry> listEntry)
        {
            AuditTrailEntry childEntry = new AuditTrailEntry();
            int n = listEntry.FindIndex(x => x.ID == faEntry.ID);
            if (n > -1 && n + 1 < listEntry.Count)
            {
                childEntry = listEntry[n + 1];
            }
            return childEntry;
        }

        private List<ActionNode> FindTheChildMarkingSet(ActionNode mGr,List<ActionNode> _lsModel)
        {
            List<ActionNode> listOfChildMarking = new List<ActionNode>();
            foreach (string mfStr in mGr.NextMarkingIDlist)
            {
                int index = _lsModel.FindIndex(x => x.ID == mfStr);
                if (index >= 0)
                {
                    listOfChildMarking.Add(_lsModel[index]);
                }

            }
            return listOfChildMarking;
        }
               
        private List<List<AMatch>> GetAllAlignmentResults(List<AMatch> MatchTree, List<AMatch> listLeafMatch)
        {
            List<List<AMatch>> alignmentTable = new List<List<AMatch>>();
            IEnumerable<AMatch> orderedLeafOnDeviations = listLeafMatch.OrderByDescending((n => n.Deviations));
            int lowestDeviation = orderedLeafOnDeviations.Reverse().ToArray()[0].Deviations;

            List<AMatch> listOfOptiLeaf = listLeafMatch.FindAll(x => x.Deviations == lowestDeviation);

            for (int j = 0; j < listOfOptiLeaf.Count; j++)
            {
                List<List<AMatch>> bestAlignment = new List<List<AMatch>>();

                AMatch OptiLeaf = listOfOptiLeaf[j];
                bestAlignment = this.FindSubFathersForACompletePath(OptiLeaf, MatchTree);
                alignmentTable.AddRange(bestAlignment);
            }
            return alignmentTable;
        }        
        private List<List<AMatch>> FindSubFathersForACompletePath(AMatch curAMatch, List<AMatch> originallist, List<AMatch> completingPath = null)
        {            
            //if curAmatch has prematch as precedures
            if (curAMatch.PreMatch != null && curAMatch.PreMatch.Count > 0)
            {
                List<List<AMatch>> pathsSetForCur = new List<List<AMatch>>();
                foreach (var preAMatch in curAMatch.PreMatch)
                {                   
                    List<List<AMatch>> pathsSetForPre = this.FindSubFathersForACompletePath(preAMatch, originallist, completingPath);
                    foreach (var completedPath in pathsSetForPre)
                    {
                        completedPath.Add(curAMatch);
                    }
                    pathsSetForCur.AddRange(pathsSetForPre);
                }
                return pathsSetForCur;
            }
            else //there are no precedors for curAmatch
            {
                if (completingPath == null)
                {
                    completingPath = new List<AMatch>();
                    completingPath.Add(curAMatch);
                }
                else
                {
                    completingPath.Add(curAMatch);
                }                
                List<List<AMatch>> nodeSetList = new List<List<AMatch>>();
                nodeSetList.Add(completingPath);

                return nodeSetList;
            }            
        }
        public void FindStartOfLoop(List<ActionNode> originalList)
        {
            ActionNode start = originalList.FindAll(x=>x.PreMarkingIDlist.Count==0)[0];
            List<ActionNode> deletedNodes = new List<ActionNode>();
            deletedNodes.Add(start);
            while(deletedNodes.Count!=0)
            {
                List<string> nextlist=deletedNodes[0].NextMarkingIDlist;
                deletedNodes.Remove(deletedNodes[0]);
                foreach(string nextId in nextlist)
                {
                    ActionNode nextNode=originalList.Find(x=>x.ID==nextId);
                    if (nextNode.PreMarkingIDlist.Count == 1)
                    {
                        deletedNodes.Add(nextNode);
                    }
                }
            }
 
        }
        public int CountAveragePathLength(ActionNode startNode, List<ActionNode> originalList)
        {
            List<List<ActionNode>> nodeSetList = new List<List<ActionNode>>();
            nodeSetList = this.FindSubPaths(startNode, originalList);
            int totalLength = 0;
            foreach (var nodeSet in nodeSetList)
            {
                totalLength += nodeSet.Count;
            }
            IEnumerable<List<ActionNode>> orderedNodeSetList = nodeSetList.OrderByDescending(n => n.Count);
            return orderedNodeSetList.ToArray()[0].Count;
        }

        //private List<List<ActionNode>> FindSubPaths(ActionNode startNode, List<ActionNode> originalList)
        //{
        //    if (startNode.NextMarkingIDlist.Count != 0)
        //    {
        //        List<List<ActionNode>> pathsSetForCur = new List<List<ActionNode>>();
        //        foreach (var ID in startNode.NextMarkingIDlist)
        //        {
        //            ActionNode node = originalList.Find(x => x.ID == ID);
        //            List<List<ActionNode>> pathsSetForPre = this.FindSubPaths(node, originalList);
        //            foreach (var completedPath in pathsSetForPre)
        //            {
        //                completedPath.Add(node);
        //            }

        //            pathsSetForCur.AddRange(pathsSetForPre);
        //        }

        //        return pathsSetForCur;
        //    }
        //    else
        //    {
        //        List<ActionNode> completedPath = new List<ActionNode>();
        //        //completedPath.Add(curAMatch);
        //        List<List<ActionNode>> pathsSetForPre = new List<List<ActionNode>>();
        //        pathsSetForPre.Add(completedPath);

        //        return pathsSetForPre;
        //    }
        //}

        public List<List<AuditTrailEntry>> ReadLogFileForLog(string filePath)
        {
            List<List<AuditTrailEntry>> logFile = new List<List<AuditTrailEntry>>();
            XmlDocument xDoc = new XmlDocument();

            //load up the xml from the location 
            xDoc.Load(filePath);

            XmlNodeList processInstanceList = xDoc.SelectNodes("//ProcessInstance");
            foreach (XmlNode processInstance in processInstanceList)
            {
                List<AuditTrailEntry> pIns = new List<AuditTrailEntry>();
                XmlNodeList auditList = processInstance.SelectNodes("AuditTrailEntry");
                int ID = 0;
                foreach (XmlNode audit in auditList)
                {
                    AuditTrailEntry sglNode = new AuditTrailEntry();
                    string workflowModelElement = audit.SelectSingleNode("WorkflowModelElement").InnerText;
                    string eventType = audit.SelectSingleNode("EventType").InnerText;
                    sglNode.Name = workflowModelElement.Replace("-","").Replace(" ","_");
                    sglNode.State = eventType;
                    sglNode.ID = ID.ToString();
                    pIns.Add(sglNode);
                    ID++;
                }
                bool flagComplete = (pIns.FindIndex(x => x.State == "complete") > -1 ? true : false);
                this.flagOnlyStart = !flagComplete;
                logFile.Add(pIns);
            }
            return logFile;
        }
        private List<AuditTrailEntry> ExractingActivitiesSetFromLog(List<List<AuditTrailEntry>> logFile)
        {
            List<AuditTrailEntry> activitiesSet = new List<AuditTrailEntry>();
            foreach (var trace in logFile)
            {
                foreach (var auditEntry in trace)
                {
                    AuditTrailEntry newEntry = new AuditTrailEntry();
                    newEntry.Name = auditEntry.Name;
                    if (!activitiesSet.Contains(newEntry))
                    {
                        activitiesSet.Add(newEntry);
                    }
                }
            }
            return activitiesSet;
        }
        public static bool datatableToCSV(DataTable dt, string pathFile)
        {
            string strLine = "";
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(pathFile, false, System.Text.Encoding.GetEncoding(-0)); //覆盖
                //表头
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (i > 0)
                        strLine += ",";
                    strLine += dt.Columns[i].ColumnName;
                }
                strLine.Remove(strLine.Length - 1);
                sw.WriteLine(strLine);
                strLine = "";
                //表的内容
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    strLine = "";
                    int colCount = dt.Columns.Count;
                    for (int k = 0; k < colCount; k++)
                    {
                        if (k > 0 && k < colCount)
                            strLine += ",";
                        if (dt.Rows[j][k] == null)
                            strLine += "";
                        else
                        {
                            string cell = dt.Rows[j][k].ToString().Trim();
                            //防止里面含有特殊符号
                            cell = cell.Replace("\"", "\"\"");
                            cell = "\"" + cell + "\"";
                            strLine += cell;
                        }
                    }
                    sw.WriteLine(strLine);
                }
                sw.Close();
                string msg = "The file is saved at：" + pathFile;
                Console.WriteLine(msg);
            }
            catch (Exception ex)
            {
                string msg = "Error：" + pathFile;
                Console.WriteLine(msg);
                return false;
            }
            return true;
        }
        public DataTable PreparingDataForShow(List<List<AMatch>> alignmentTable)
        {
            DataTable dtForShow = new DataTable();
            for (int i = 0; i < alignmentTable[0].Count - 1; i++)
            {
                dtForShow.Columns.Add(i.ToString(), typeof(string));
            }
            #region to show
            foreach (var alignment in alignmentTable)
            {
                DataRow rowLog = dtForShow.NewRow();
                DataRow rowModel = dtForShow.NewRow();
                int colNum = 0;
                for (int i = 1; i < alignment.Count; i++)
                {
                    switch (alignment[i].MatchType)
                    {
                        case TypeOfMatch.BothCorrect:
                            rowLog[colNum] = alignment[i].Entry.Name;
                            rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                            break;
                        case TypeOfMatch.CTaskFEntry:
                            rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                            rowLog[colNum] = " ┴ ";
                            break;
                        case TypeOfMatch.FTaskCEntry:
                            rowLog[colNum] = alignment[i].Entry.Name;
                            rowModel[colNum] = " ┴ ";
                            break;
                        case TypeOfMatch.BothFake:
                            if (alignment[i].TaskMarking.ID == alignment[i - 1].TaskMarking.ID)
                            {
                                rowLog[colNum] = alignment[i].Entry.Name;
                                rowModel[colNum] = " ┴ ";
                            }
                            else if (alignment[i].Entry.ID == alignment[i - 1].Entry.ID)
                            {
                                rowModel[colNum] = alignment[i].TaskMarking.Elment.Name;
                                rowLog[colNum] = " ┴ ";
                            }
                            break;
                    }
                    //this.log.Text += "  |  ";
                    //this.log.Text += rowLog[colNum];
                    //this.model.Text += "  |  ";
                    //this.model.Text += rowModel[colNum];
                    colNum++;
                }
                dtForShow.Rows.Add(rowLog);
                dtForShow.Rows.Add(rowModel);
                DataRow emptyR = dtForShow.NewRow();
                dtForShow.Rows.Add(emptyR);
            }
            #endregion
            return dtForShow;
        }
    }
}
