﻿using LearnTop.Shared.Domain;

namespace LearnTop.Shared.Application.Exceptions;

public sealed class LearnTopException(string requestName, Error? error = default, Exception? innerException = default)
    : Exception("Application exception", innerException)
{
    public string RequestName { get; } = requestName;

    public Error? Error { get; } = error;
}
