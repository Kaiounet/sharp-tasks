using sharp_tasks.Enums;

namespace sharp_tasks.Helpers;

public static class StateHelper
{

    public static State GetNextState(State currentState)
    {
        return currentState switch
        {
            State.TODO => State.IN_PROGRESS,
            State.IN_PROGRESS => State.DONE,
            State.DONE => State.DONE,
            _ => State.TODO
        };
    }

    public static string GetStateDisplayText(State state)
    {
        return state switch
        {
            State.TODO => "To Do",
            State.IN_PROGRESS => "In Progress",
            State.DONE => "Done",
            _ => "Unknown"
        };
    }

    public static string GetStateBadgeClass(State state)
    {
        return state switch
        {
            State.TODO => "badge bg-secondary",
            State.IN_PROGRESS => "badge bg-primary",
            State.DONE => "badge bg-success",
            _ => "badge bg-dark"
        };
    }

    public static bool IsValidTransition(State fromState, State toState)
    {
        // Allow any transition for now
        return true;
    }
}