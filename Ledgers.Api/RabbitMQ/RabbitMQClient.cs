using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ledgers.Api.Models;
using RabbitMQ.Client;

namespace Ledgers.Api.RabbitMQ
{
    public class RabbitMQClient
    {
        private IConnection _connection;
        private IModel _model;
        private QueueingBasicConsumer _consumer;
        private string _replyQueueName;

        public void CreateConnection()
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };

            _connection = factory.CreateConnection();
            _model = _connection.CreateModel();
            _replyQueueName = _model.QueueDeclare("rpc_reply", true, false, false, null);
            _consumer = new QueueingBasicConsumer(_model);
            _model.BasicConsume(_replyQueueName, true, _consumer);
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public string PostTransaction(SourceTransaction sourceTransaction)
        {

            return string.Empty;

        }

    }
}
