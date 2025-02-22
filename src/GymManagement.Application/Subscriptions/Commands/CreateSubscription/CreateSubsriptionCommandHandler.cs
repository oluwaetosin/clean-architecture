using System;
using MediatR;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription;

public class CreateSubsriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, Guid>
{
    public Task<Guid> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
      return Task.FromResult(Guid.NewGuid());
    }
}
