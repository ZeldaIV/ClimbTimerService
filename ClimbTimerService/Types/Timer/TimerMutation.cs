using ClimbTimerService.Services;
using HotChocolate.Language;

namespace ClimbTimerService.Types.Timer;

[ExtendObjectType(OperationType.Mutation)]
public class TimerMutation
{
    public TimerState Reset(string id, TimerService timerService) => timerService.Reset(id);

    public TimerState Restart(string id, TimerService timerService) => timerService.Restart(id);

    public TimerState Toggle(string id, TimerService timerService) => timerService.Toggle(id);

    [Error<StopwatchExistsException>]
    public bool CreateStopWatch(string id, TimerService timerService) => timerService.CreateNewStopwatch(id);

    public bool RemoveStopwatch(string id, TimerService timerService) => timerService.RemoveStopwatch(id);
}