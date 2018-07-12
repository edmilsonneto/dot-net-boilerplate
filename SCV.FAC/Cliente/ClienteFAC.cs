
using SCV.DAL;

namespace SCV.FAC
{
    public class ClienteFAC
    {
        private static ClienteDAL instance;

        public static ClienteDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClienteDAL();
                }
                return instance;
            }
        }
    }
}
