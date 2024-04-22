using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafka.WinForms.Client.Models
{
    public class KafkaMessageViewModel
    {
        private string _historic = String.Empty;

        public KafkaMessageViewModel() { }

        public KafkaMessageViewModel(string historic)
        {
            _historic = historic;
        }

        [DisplayName("Histórico")]
        public string Historic => _historic;
    }
}
