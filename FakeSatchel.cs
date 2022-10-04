using Vasi;


public static class FakeSatchel
{
    public static void InsertCustomAction(this PlayMakerFSM fsm, string state,System.Action action,int index)
    {
        fsm.GetState(state).InsertMethod(index, action);
    }
    public static void AddCustomAction(this PlayMakerFSM fsm, string state, System.Action action)
    {
        fsm.GetState(state).AddMethod(action);
    }
    public static void RemoveAction(this PlayMakerFSM fsm, string state, int index)
    {
        fsm.GetState(state).RemoveAction(index);
    }
    public static void AddTransition(this PlayMakerFSM fsm, string from, string e,string to)
    {
        fsm.GetState(from).AddTransition(e, to);
    }
}