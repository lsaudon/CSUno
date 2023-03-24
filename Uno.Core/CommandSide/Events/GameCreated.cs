﻿namespace Uno.Core.CommandSide.Events;

public record GameCreated : IDomainEvent
{
    public GameId Id { get; }

    public GameCreated(GameId id)
    {
        Id = id;
    }

    public IAggregateId GetAggregateId() => Id;
}