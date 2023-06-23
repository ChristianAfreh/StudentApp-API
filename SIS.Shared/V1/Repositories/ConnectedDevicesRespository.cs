using SIS.Shared.Entities.SISContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.V1.Repositories
{
	public interface IConnectedDevicesRespository : IBaseRepository<Connecteddevice>
	{

	}
	public class ConnectedDevicesRespository : BaseRepository<Connecteddevice>, IConnectedDevicesRespository
	{
		public ConnectedDevicesRespository(SISContext DbContext) : base(DbContext)
		{

		}
	}
}
