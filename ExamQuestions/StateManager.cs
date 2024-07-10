using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace ExamQuestions
{
    public class StateManager
    {
        private HttpSessionState Session;

        public StateManager(HttpSessionState session)
        {
            this.Session = session;
        }

        public void SetState(string key, object value)
        {
            Session[key] = value;
        }

        public T GetState<T>(SqlTriggerAttribute key)
        {
            if (Session[key] !== null)
            {
                return (T)Session[key];
            }
            else
            {
                return default(T);
            }
        }

        public void RemoveState(string key)
        {
            Session.Remove(key);
        }
    }
}
