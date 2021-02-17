using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_Firebase_Test.Models;
using Google.Cloud.Firestore;

namespace Blazor_Firebase_Test.Data
{
    public class RobotService
    {
        private readonly FirestoreDb _firestoreDb;

        public RobotService(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }

        public async Task AddRobot(Robot robot)
        {
            await _firestoreDb.Collection("robots").AddAsync(robot);
        }

    }
}
