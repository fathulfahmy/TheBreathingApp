using System;
using System.Text;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Maui.Storage;


namespace TheBreathingApp
{
    internal class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://thebreathingapp-d07cb-default-rtdb.asia-southeast1.firebasedatabase.app/");
        public async Task AddRecord(string dateRecorded, int score, string result)
        {
            await firebase
                .Child("TestRecords")
                .PostAsync(new TestRecords() { DateRecorded = dateRecorded, Score = score, Result = result });
        }

        public async Task<List<TestRecords>> GetAllTestRecords()
        {
            return (await firebase
                .Child("TestRecords")
                .OnceAsync<TestRecords>()).Select(item => new TestRecords
                {
                    DateRecorded = item.Object.DateRecorded,
                    Score = item.Object.Score,
                    Result = item.Object.Result
                }).ToList();
        }
    }



}
