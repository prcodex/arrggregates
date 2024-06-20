using Arrggregates.Application.Contracts;

namespace Arrggregates.Application.Abstractions
{
    public abstract record ViewModel
        : IViewModel
    {
        public virtual Guid Id { get; set; }
    }
}
