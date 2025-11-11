using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Analytics;

namespace RamjetAnvil.UnityEditor {

    [InitializeOnLoad]
    public class UnityServicesSetup {
        static UnityServicesSetup() {
            var userId = Environment.UserName + " (developer)";
            // FIXME TRAVIS Code contains errors. No network support at this time
            throw new NotImplementedException("Code has not been migrated.");
            // Analytics.SetUserId(userId);
        }
    }
}
