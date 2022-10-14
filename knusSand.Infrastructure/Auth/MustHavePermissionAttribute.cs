
using KnusSandbox.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace knusSand.Infrastructure.Auth;

public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource) =>
        Policy = FSHPermission.NameFor(action, resource);
}