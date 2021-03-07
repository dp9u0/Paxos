namespace Paxos
{
  /// <summary>
  /// 状态机用于执行通过的提案
  /// </summary>
  public abstract class StateMachine
  {
    public abstract void Execute();
  }
}
