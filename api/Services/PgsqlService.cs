using api.Models;
using Npgsql;

namespace api.Services
{
	public class PgsqlService
	{
		public NpgsqlConnection Conn { get; }

		public PgsqlService(DatabaseSettings settings)
		{
			Conn = new NpgsqlConnection(settings.ConnectionString);
			Conn.OpenAsync().Wait();
		}
	}
}