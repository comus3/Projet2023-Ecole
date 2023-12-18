using System;
using System.Collections.Generic;

namespace schoolManager.Services
{
    class Guid
    {
        public static string GenerateNewUid(List<object> existingObjects)
        {
            string newUid;
            bool isUnique;

            do
            {
                // Generate a new UID
                newUid = Guid.NewGuid().ToString();

                // Check if the UID is unique
                isUnique = !existingObjects.Any(obj => obj.Uid == newUid);

            } while (!isUnique);

            return newUid;
        }
    }
}