using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace Blazor_Firebase_Test.Models
{
    [FirestoreData]
    public class Robot
    {
        [FirestoreDocumentId]
        public string RobotId { get; set; }
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public int WinCount { get; set; }
        [FirestoreProperty]
        public int LossCount { get; set; }
        [FirestoreProperty]
        public int TieCount { get; set; }
        [FirestoreProperty]
        public string EnteredBy { get; set; }
        [FirestoreDocumentUpdateTimestamp]
        public DateTime EnteredDate { get; set; }
    }
}
