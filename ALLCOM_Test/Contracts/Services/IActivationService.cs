namespace ALLCOM_Test.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
