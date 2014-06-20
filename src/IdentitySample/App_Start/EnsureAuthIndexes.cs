namespace IdentitySample
{
	using AspNet.Identity.MongoDB;

	public class EnsureAuthIndexes
	{
		public static void Exist()
		{
			var context = ApplicationIdentityContext.Create();
			IndexChecks.EnsureUniqueIndexOnUserName(context.Users);
			IndexChecks.EnsureUniqueIndexOnRoleName(context.Roles);
		}
	}
}