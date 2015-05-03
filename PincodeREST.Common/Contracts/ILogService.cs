using log4net;

namespace PincodeREST.Common.Contracts
{
    public interface ILogService
    {
        ILog Logger();
    }
}
