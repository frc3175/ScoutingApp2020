package com.frc3175.scoutcompanionapp;

import android.Manifest;
import android.content.pm.PackageManager;
import android.os.StrictMode;
import android.support.v4.app.ActivityCompat;
import android.support.v4.content.ContextCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;
import com.frc3175.scoutcompanionapp.Event;
import com.thebluealliance.api.v3.*;

public class MainScreen extends AppCompatActivity {

    public static final String authKey = ""; //Insert auth key here
    public TBA tba;
    private static final int STORAGE_PERMISSION_CODE = 100;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_screen);
        checkPermission(Manifest.permission.WRITE_EXTERNAL_STORAGE, STORAGE_PERMISSION_CODE);
        this.tba = new TBA(authKey);
    }

    public void downloadMatch(View view) {
        try {
            TextView eCodeView = (TextView) findViewById(R.id.editText);
            Toast myToast;
            String eventKey = eCodeView.getText().toString();
            didWork(getData(eventKey));
        }
            catch(Exception e) {
            e.printStackTrace();
            }
    }

    protected boolean getData(String eventKey) {

        Event newEvent = new Event(tba, eventKey);
        boolean success = newEvent.genMatchList();
        didWork2(newEvent.printTeamList(), newEvent);
        return success;
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

    protected void didWork(boolean answer) {
        Toast myToast;
        if (answer == true) {
            myToast = Toast.makeText(this, "Success!", Toast.LENGTH_SHORT);
        }
        else {
            myToast = Toast.makeText(this, "Invalid event key.", Toast.LENGTH_SHORT);
        }
        //myToast.show();
    }

    protected void didWork2(boolean answer, Event event) {
        Toast myToast;
        if (answer == true) {
            myToast = Toast.makeText(this, "Success! Downloaded Event: \n" + event.getEventName() + "\nYou will find your files in Documents.", Toast.LENGTH_SHORT);
        }
        else {
            myToast = Toast.makeText(this, "Invalid event key.", Toast.LENGTH_SHORT);
        }
        myToast.show();
    }
}
