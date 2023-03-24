﻿namespace Uno.Core.CommandSide.Events;

public record PlayerJoined : IDomainEvent
{
    public GameId Id { get; }
    public PlayerId PlayerId { get; }

    public PlayerJoined(GameId id, PlayerId playerId)
    {
        Id = id;
        PlayerId = playerId;
    }

    public IAggregateId GetAggregateId() => Id;
}