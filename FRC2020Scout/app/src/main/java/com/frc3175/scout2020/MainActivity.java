package com.frc3175.scout2020;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Environment;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.Toast;

import java.io.File;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class MainActivity extends AppCompatActivity {

    private static final int STORAGE_PERMISSION_CODE = 103;
    public ArrayList<MyMatch> matches;
    public Spinner s; //match#
    public Spinner s2; //alliance station
    public String teamMatch;
    public String matchNo;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        checkPermission(Manifest.permission.READ_EXTERNAL_STORAGE, STORAGE_PERMISSION_CODE);
        checkPermission(Manifest.permission.WRITE_EXTERNAL_STORAGE, STORAGE_PERMISSION_CODE);
        File dir = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOCUMENTS);
        File file = new File(dir, "/FRC2020Scout/matchlist.txt");
        ArrayList<String> arraySpinner = new ArrayList<>();
        String[] arraySpinner2 = new String[] {
                "Red 1", "Red 2", "Red 3", "Blue 1", "Blue 2", "Blue 3"
        };
        this.matches = new ArrayList<>();
        String line;
        try {
            Scanner scanner = new Scanner(file);
            while(scanner.hasNext()) {
                line = scanner.nextLine();
                String[] data = line.split(",");
                this.matches.add(new MyMatch(data));
                arraySpinner.add(data[0]);
            }
        } catch (IOException e) {
            Toast myToast = Toast.makeText(this, "No matchlist.txt file found. Please download the companion app in order to proceed.", Toast.LENGTH_SHORT);
            myToast.show();
        }
        s = (Spinner) findViewById(R.id.spnMatches);
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,
                android.R.layout.simple_spinner_item, arraySpinner);
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        s2 = (Spinner) findViewById(R.id.spnTeam);
        s.setAdapter(adapter);
        ArrayAdapter<String> adapter2 = new ArrayAdapter<String>(this,
                android.R.layout.simple_spinner_item, arraySpinner2);
        adapter2.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        s2.setAdapter(adapter2);
    }

    public void checkPermission(String permission, int requestCode)
    {
        if (ContextCompat.checkSelfPermission(this, permission)
                == PackageManager.PERMISSION_DENIED) {

            // Requesting the permission
            ActivityCompat.requestPermissions(this,
                    new String[] { permission },
                    requestCode);
        }
        else {
        }
    }

    public void startMatch(View view) {
        try {
            int matchSelect = s.getSelectedItemPosition();
            int allianceStation = s2.getSelectedItemPosition();
            this.teamMatch = matches.get(matchSelect).teams[allianceStation];
            this.matchNo = matches.get(matchSelect).matchNum;
            Intent autonIntent = new Intent(this, AutonomousScout.class);
            autonIntent.putExtra("teamMatch", teamMatch);
            autonIntent.putExtra("matchNo", matchNo);
            startActivity(autonIntent);
            if (matchSelect < s.getAdapter().getCount() - 1) {
                s.setSelection(matchSelect + 1);
            }
            //Start autons
        } catch (ArrayIndexOutOfBoundsException e) {
            Toast myToast = Toast.makeText(this, "No matchlist.txt file found. Please download the companion app in order to proceed.", Toast.LENGTH_SHORT);
            myToast.show();
        }
    }

}
