using System;
using System.Net;
using StackExchange.Redis;

namespace myselfFast.Fund.Core.Component.Cache.Redis
{
    /// <summary>
    /// Redis connection wrapper
    /// </summary>
    public class RedisConnectionWrapper : IRedisConnectionWrapper
    {
        private static RedisConnectionWrapper redisConnectionWrapper;
        private static Object lockWrapper = new Object();
        public static RedisConnectionWrapper CreateInstance(string connectionString)
        {
            if (redisConnectionWrapper == null)
            {
                lock (lockWrapper)
                {
                    if (redisConnectionWrapper == null)
                    {
                        redisConnectionWrapper = new RedisConnectionWrapper(connectionString);
                        
                    }
                }
            }
            return redisConnectionWrapper;
        }


        private readonly Lazy<string> _connectionString;
        private readonly string connectionString;
        private volatile ConnectionMultiplexer _connection;
        private readonly object _lock = new object();

        public RedisConnectionWrapper(string connectionString)
        {
            this.connectionString = connectionString;
            this._connectionString = new Lazy<string>(GetConnectionString);
        }

        private string GetConnectionString()
        {
            return connectionString;
        }

        private ConnectionMultiplexer GetConnection()
        {
            if (_connection != null && _connection.IsConnected) return _connection;

            lock (_lock)
            {
                if (_connection != null && _connection.IsConnected) return _connection;

                if (_connection != null)
                {
                    //Connection disconnected. Disposing connection...
                    _connection.Dispose();
                }

                //Creating new instance of Redis Connection
                _connection = ConnectionMultiplexer.Connect(_connectionString.Value);
            }

            return _connection;
        }

        public IDatabase Database(int? db = null)
        {
            return GetConnection().GetDatabase(db ?? -1); //_settings.DefaultDb);
        }

        public IServer Server(EndPoint endPoint)
        {
            return GetConnection().GetServer(endPoint);
        }

        public EndPoint[] GetEndpoints()
        {
            return GetConnection().GetEndPoints();
        }

        public void FlushDb(int? db = null)
        {
            var endPoints = GetEndpoints();

            foreach (var endPoint in endPoints)
            {
                Server(endPoint).FlushDatabase(db ?? -1); //_settings.DefaultDb);
            }
        }

        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Dispose();
            }
        }
    }
}
