package com.frc3175.frc2020scouting;

import android.os.Environment;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.SeekBar;
import android.widget.Switch;
import android.widget.TextView;
import android.widget.Toast;

import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

public class EndgameActivity extends AppCompatActivity {

    public String matchNo;
    public String team;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_endgame);
        String teleNotes = getIntent().getStringExtra("TeleNotes");
        this.matchNo = getIntent().getStringExtra("matchNo");
        this.team = getIntent().getStringExtra("teamMatch");
        EditText notes = (EditText) findViewById(R.id.teleNotesEnd);
        notes.setText(teleNotes);

    }
    public void subBalanced(View view) {
        TextView balance = (TextView) findViewById(R.id.txtBalancedWith);
        String countString = balance.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count > 0) {
            count--;
        }
        balance.setText(count.toString());
    }
    public void addBalanced(View view) {
        TextView balance = (TextView) findViewById(R.id.txtBalancedWith);
        String countString = balance.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count < 2) {
            count++;
        }
        balance.setText(count.toString());
    }


    public int getCrossed() {
        return getIntent().getIntExtra("Crossed", 0);
    }

    public int getLowGoalsAuto() {
        return getIntent().getIntExtra("LowAuto", 0);
    }

    public int getHighGoalsAuto() {
        return getIntent().getIntExtra("HighAuto", 0);
    }

    public int getInnerGoalsAuto() {return getIntent().getIntExtra("InnerAuto", 0);}

    public int getExtraGrabbed() {
        return getIntent().getIntExtra("ExtraGrab", 0);
    }

    public int getRendes() {
        return getIntent().getIntExtra("Rendevouz", 0);
    }

    public int getTrench() {
        return getIntent().getIntExtra("Trench", 0);
    }
    public int getLowGoalsTele() {
        return getIntent().getIntExtra("LowTele", 0);
    }

    public int getHighGoalsTele() {
        return getIntent().getIntExtra("HighTele", 0);
    }

    public int getInnerGoalsTele() {
        return getIntent().getIntExtra("InnerTele", 0);
    }

    public int getFouls() {
        return getIntent().getIntExtra("Fouls", 0);
    }

    public int getClimbed() {
        Switch crossed = (Switch) findViewById(R.id.switchClimbed);
        if (crossed.isChecked()) {
            return 1;
        } else {
            return 0;
        }
    }

    public int getLevel() {
        Switch crossed = (Switch) findViewById(R.id.switchLevel);
        if (crossed.isChecked() && getClimbed() == 1) {
            return 1;
        } else {
            return 0;
        }
    }

    public int getTeamsBalancedWith() {
        TextView balanced = (TextView) findViewById(R.id.txtBalancedWith);
        if (getLevel() == 1) {
            return Integer.parseInt(balanced.getText().toString());
        } else {
            return 0;
        }
    }

    public int getCpS2() {
        return getIntent().getIntExtra("ControlPanel2", 0);
    }

    public int getCpS3() {
        return getIntent().getIntExtra("ControlPanel3", 0);
    }

    public int getBroken() {
        return getIntent().getIntExtra("Broken", 0);
    }

    public int getComms() {
        return getIntent().getIntExtra("Comms", 0);
    }

    public int getDefense() {
        return getIntent().getIntExtra("Defense", 0);
    }

    public int getSpotOnBar() {
        SeekBar crossed = (SeekBar) findViewById(R.id.sldBalancedOnBar);
        return crossed.getProgress();
    }

    public String getAutoNotes() {
        return getIntent().getStringExtra("AutoNotes");
    }

    public String getTeleNotes() {
        EditText notes = (EditText) findViewById(R.id.teleNotesEnd);
        return notes.getText().toString();
    }

    public void submitMatch(View view) {
       // Intent endIntent = new Intent(this, EndgameActivity.class);
       // startActivity(endIntent);
        //Export File
        String data = this.matchNo+'|'+this.team+"|";
        data+=getCrossed()+"|"+getLowGoalsAuto()+"|"+getHighGoalsAuto()+"|" + getInnerGoalsAuto() +"|"+getExtraGrabbed()+"|";
        data+=getRendes()+"|"+getTrench()+"|"+getLowGoalsTele()+"|"+getHighGoalsTele()+"|" + getInnerGoalsTele() + "|";
        data+=getFouls()+"|"+getClimbed()+"|"+getLevel()+"|"+getTeamsBalancedWith()+"|"+getCpS2()+'|'+getCpS3()+"|";
        data+=getBroken()+"|"+getComms()+"|"+getDefense()+"|"+getSpotOnBar()+"|"+getAutoNotes()+"|"+getTeleNotes()+"|";
        File dir = Environment.getExternalStoragePublicDirectory(Environment.DIRECTORY_DOCUMENTS);
        File file = new File(dir,"/FRC2020Scout/data.txt");
        try {
            file.getParentFile().mkdirs();
            file.createNewFile();
            FileWriter fw = new FileWriter(file);
            PrintWriter pw = new PrintWriter(fw);
            pw.println(data);
            pw.close();
            Toast myToast;
            myToast = Toast.makeText(this, "Export Successful!", Toast.LENGTH_SHORT);
            myToast.show();
            finish();
        }catch (IOException e) {
            Toast myToast;
            myToast = Toast.makeText(this, "Export Failed.", Toast.LENGTH_SHORT);
            myToast.show();
            e.printStackTrace();
        }
        finish();


    }
}
