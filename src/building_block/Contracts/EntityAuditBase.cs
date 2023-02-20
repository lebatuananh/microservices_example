using Contracts.Domains;
using Contracts.Domains.Interfaces;

namespace Contracts;

public abstract class EntityAuditBase<T> : EntityBase<T>, IAuditable
{
    public DateTimeOffset CreatedDate { get; set; }
    
    public DateTimeOffset? LastModifiedDate { get; set; }
}