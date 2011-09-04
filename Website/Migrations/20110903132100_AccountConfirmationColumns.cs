using System.Data;
using Migrator.Framework;

namespace NuGetGallery {
    [Migration(20110903132100)]
    public class AccountConfirmationColumns : Migration {
        public override void Up() {
            Database.AddColumn("Users", "Confirmed", DbType.Boolean, 0, ColumnProperty.NotNull, false);
            Database.AddColumn("Users", "ConfirmationToken", DbType.String, 32, ColumnProperty.Null);
        }

        public override void Down() {
            Database.RemoveColumn("Users", "ConfirmationToken");
            Database.RemoveColumn("Users", "Confirmed");
        }
    }
}
