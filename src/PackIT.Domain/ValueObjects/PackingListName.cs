﻿using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects;

public record PackingListName
{
    public string Value { get; }

    public PackingListName(string value)
    {
        if (string.IsNullOrWhiteSpace(value)) throw new EmptyPackingListNameException();

        Value = value;
    }

    public static implicit operator string(PackingListName name)
    {
        return name.Value;
    }

    public static implicit operator PackingListName(string name)
    {
        return new PackingListName(name);
    }
}