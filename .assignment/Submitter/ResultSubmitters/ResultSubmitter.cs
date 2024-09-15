using Submitter.Configuration;

namespace Submitter.ResultSubmitters;

public abstract class ResultSubmitter
{
    public AssignmentConfig AssignmentConfig { get; } = null!;

    public abstract void SubmitResult();
}