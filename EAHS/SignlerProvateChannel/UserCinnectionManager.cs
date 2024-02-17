using EAHS.Infrastructure;
using System.Collections.Generic;
using System;

namespace EAHS.SignlerProvateChannel
{
    public class UserConnectionManager : IUserConnectionManager
    {
        private static Dictionary<string, List<string>> userConnectionMap = new Dictionary<string, List<string>>();
        private static string userConnectionMapLocker = string.Empty;
        //when user login signalr add on userConnectionMap list
        public void KeepUserConnection(string userId, string connectionId)
        {
            try
            {
                lock (userConnectionMapLocker)
                {
                    if (!userConnectionMap.ContainsKey(userId))
                    {
                        userConnectionMap[userId] = new List<string>();
                    }
                    userConnectionMap[userId].Add(connectionId);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        //when user logout or close the window signalr remove user from list 
        public void RemoveUserConnection(string connectionId)
        {
            //This method will remove the connectionId of user
            lock (userConnectionMapLocker)
            {
                foreach (var userId in userConnectionMap.Keys)
                {
                    if (userConnectionMap.ContainsKey(userId))
                    {
                        if (userConnectionMap[userId].Contains(connectionId))
                        {
                            userConnectionMap[userId].Remove(connectionId);
                            break;
                        }
                    }
                }
            }
        }

        //check user exsits in collection list 
        public List<string> GetUserConnections(string userId)
        {
            var conn = new List<string>();
            lock (userConnectionMapLocker)
            {
                if (userConnectionMap.ContainsKey(userId))
                {
                    conn = userConnectionMap[userId];
                }
            }
            return conn;
        }
    }
}
