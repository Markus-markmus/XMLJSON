using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Add the System.IO namespace to work with directories
using System.IO;

public class DirectoryCreator : MonoBehaviour
{
    void Start()
    {
        // Create a directory in the persistent data path
        string directoryPath = Application.persistentDataPath + "/MyDirectory";

        // Check if the directory exists
        if (!Directory.Exists(directoryPath))
        {
            // Create the directory
            Directory.CreateDirectory(directoryPath);
            Debug.Log("Directory created at: " + directoryPath);
        }
        else
        {
            Debug.Log("Directory already exists at: " + directoryPath);
        }
    }
}