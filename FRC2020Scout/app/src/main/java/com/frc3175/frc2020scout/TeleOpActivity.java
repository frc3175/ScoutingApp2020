package com.frc3175.frc2020scout;

import android.content.Intent;
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

public class TeleOpActivity extends AppCompatActivity {
    String matchNo;
    String team;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tele_op);
        loadData();
    }

    public void loadData() {
        this.matchNo = getIntent().getStringExtra("matchNo");
        this.team = getIntent().getStringExtra("teamMatch");
        TextView mNo = (TextView) findViewById(R.id.matchNoText);
        TextView tNo = (TextView) findViewById(R.id.teamNumberText);
        mNo.setText(matchNo);
        tNo.setText(team);

        //this.matchNo = MainActivity.matchNo;
    }

    public void addHighTele(View view) {
        TextView highTele = (TextView) findViewById(R.id.txtHighGoalCountTele);
        String countString = highTele.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count < 10) {
            count++;
        }
        highTele.setText(count.toString());
    }
    public void subHighTele(View view) {
        TextView highTele = (TextView) findViewById(R.id.txtHighGoalCountTele);
        String countString = highTele.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count > 0) {
            count--;
        }
        highTele.setText(count.toString());
    }

    public void addLowTele(View view) {
        TextView lowTele = (TextView) findViewById(R.id.txtLowGoalCountTele);
        String countString = lowTele.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count < 10) {
            count++;
        }
        lowTele.setText(count.toString());
    }
    public void subLowTele(View view) {
        TextView lowTele = (TextView) findViewById(R.id.txtLowGoalCountTele);
        String countString = lowTele.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count > 0) {
            count--;
        }
        lowTele.setText(count.toString());
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

    public void subFouls(View view) {
        TextView fouls = (TextView) findViewById(R.id.txtFoulCount);
        String countString = fouls.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count > 0) {
            count--;
        }
        fouls.setText(count.toString());
    }

    public void addFouls(View view) {
        TextView fouls = (TextView) findViewById(R.id.txtFoulCount);
        String countString = fouls.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count < 25) {
            count++;
        }
        fouls.setText(count.toString());
    }

    public void openDefense(View view) {
        Intent defenseIntent = new Intent(this, DefenseInstructions.class);
        startActivity(defenseIntent);
    }

    public int getCrossed() {
        if (getIntent().getBooleanExtra("Crossed",false)) {
            return 1;
        } else {
            return 0;
        }
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
        if (getIntent().getBooleanExtra("Rendevouz", false)) {
            return 1;
        } else {
            return 0;
        }
    }

    public int getTrench() {
        if (getIntent().getBooleanExtra("Trench", false)) {
            return 1;
        } else {
            return 0;
        }
    }
    public int getLowGoalsTele() {
        TextView lowGoals = (TextView) findViewById(R.id.txtLowGoalCountTele);
        return Integer.parseInt(lowGoals.getText().toString());
    }

    public int getHighGoalsTele() {
        TextView highGoals = (TextView) findViewById(R.id.txtHighGoalCountTele);
        return Integer.parseInt(highGoals.getText().toString());
    }

    public int getFouls() {
        TextView fouls = (TextView) findViewById(R.id.txtFoulCount);
        return Integer.parseInt(fouls.getText().toString());
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
        Switch crossed = (Switch) findViewById(R.id.switchStage2);
        if (crossed.isChecked()) {
            return 1;
        } else {
            return 0;
        }
    }

    public int getCpS3() {
        Switch crossed = (Switch) findViewById(R.id.switchStage3);
        if (crossed.isChecked()) {
            return 1;
        } else {
            return 0;
        }
    }

    public int getBroken() {
        Switch crossed = (Switch) findViewById(R.id.switchBrokenRobot);
        if (crossed.isChecked()) {
            return 1;
        } else {
            return 0;
        }
    }

    public int getComms() {
        Switch crossed = (Switch) findViewById(R.id.switchLostComms);
        if (crossed.isChecked()) {
            return 1;
        } else {
            return 0;
        }
    }

    public int getDefense() {
        SeekBar crossed = (SeekBar) findViewById(R.id.seekDefense);
        return crossed.getProgress();
    }

    public int getSpotOnBar() {
        SeekBar crossed = (SeekBar) findViewById(R.id.sldBalancedOnBar);
        return crossed.getProgress();
    }

    public String getAutoNotes() {
        return getIntent().getStringExtra("AutoNotes");
    }

    public String getTeleNotes() {
        EditText notes = (EditText) findViewById(R.id.txtNotesTele);
        return notes.getText().toString();
    }

    public void submitMatch(View view) {
        Intent endIntent = new Intent(this, EndgameActivity.class);
        startActivity(endIntent);
        //Export File
        String data = this.matchNo+'|'+this.team+"|";
        data+=getCrossed()+"|"+getLowGoalsAuto()+"|"+getHighGoalsAuto()+"|" + getInnerGoalsAuto() +"|"+getExtraGrabbed()+"|";
        data+=getRendes()+"|"+getTrench()+"|"+getLowGoalsTele()+"|"+getHighGoalsTele()+"|";
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


    }
}
