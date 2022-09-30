using System;

namespace Web.Models
{
    public interface IDateService
    {
        DateTime GetDateTime { get; }
    }

    public interface ISingletonDateService : IDateService
    {

    }

    public interface IScopedDateService : IDateService
    {

    }

    public interface ITransientDateService : IDateService
    {

    }
}
