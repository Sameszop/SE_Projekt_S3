using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SQLite4Unity3d;

public class Player {
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Score { get; set; }
}

public class Database : MonoBehaviour {
    SQLiteConnection db;

    void Start() {
        string dbPath = System.IO.Path.Combine(Application.persistentDataPath, "game.db");
        db = new SQLiteConnection(dbPath, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);

        db.CreateTable<Player>();

        // db.Insert(new Player { Name = "Alice", Score = 100 });
        //
        // foreach (var p in db.Table<Player>()) {
        //     Debug.Log("Player: " + p.Name + " Score: " + p.Score);
        // }
    }
}
