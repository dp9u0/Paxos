using Paxos.Algorithm;
namespace Paxos
{
  /// <summary>
  /// 一个Paxos 实例
  /// </summary>
  public class PaxosInstance
  {
    private readonly Proposer _proposer = new Proposer();
    private readonly Acceptor _acceptor = new Acceptor();
    private readonly Learner _learner = new Learner();

  }
}
