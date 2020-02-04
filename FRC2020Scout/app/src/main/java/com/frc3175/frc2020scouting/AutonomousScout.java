package com.frc3175.frc2020scouting;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Switch;
import android.widget.TextView;

import com.frc3175.frc2020scouting.R;

public class AutonomousScout extends AppCompatActivity {
    String team;
    String matchNo;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_autonomous_scout);
        loadData();
    }

    public void loadData() {
        this.matchNo = getIntent().getStringExtra("matchNo");
        this.team = getIntent().getStringExtra("teamMatch");
        TextView mNo = (TextView) findViewById(R.id.matchNoText);
        TextView tNo = (TextView) findViewById(R.id.teamNumberText);
        mNo.setText(this.matchNo);
        tNo.setText(this.team);

        //this.matchNo = MainActivity.matchNo;
    }

    public void addHighAuto(View view) {
        TextView highAuto = (TextView) findViewById(R.id.txtHighGoalCountAuto);
        String countString = highAuto.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count < 10) {
            count++;
        }
        highAuto.setText(count.toString());
    }
    public void subHighAuto(View view) {
        TextView highAuto = (TextView) findViewById(R.id.txtHighGoalCountAuto);
        String countString = highAuto.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count > 0) {
            count--;
        }
        highAuto.setText(count.toString());
    }

    public void addLowAuto(View view) {
        TextView lowAuto = (TextView) findViewById(R.id.txtLowGoalCountAuto);
        String countString = lowAuto.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count < 10) {
            count++;
        }
        lowAuto.setText(count.toString());
    }
    public void subLowAuto(View view) {
        TextView lowAuto = (TextView) findViewById(R.id.txtLowGoalCountAuto);
        String countString = lowAuto.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count > 0) {
            count--;
        }
        lowAuto.setText(count.toString());
    }

    public void addExtraAuto(View view) {
        TextView extraAuto = (TextView) findViewById(R.id.txtExtraCountAuto);
        String countString = extraAuto.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count < 10) {
            count++;
        }
        extraAuto.setText(count.toString());
    }
    public void subExtraAuto(View view) {
        TextView extraAuto = (TextView) findViewById(R.id.txtExtraCountAuto);
        String countString = extraAuto.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count > 0) {
            count--;
        }
        extraAuto.setText(count.toString());
    }

    public void subInnerAuto(View view) {
        TextView innerAuto = (TextView) findViewById(R.id.txtCountInnerAuto);
        String countString = innerAuto.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count > 0) {
            count--;
        }
        innerAuto.setText(count.toString());
    }
    public void addInnerAuto(View view) {
        TextView innerAuto = (TextView) findViewById(R.id.txtCountInnerAuto);
        String countString = innerAuto.getText().toString();
        Integer count = Integer.parseInt(countString);
        if (count < 10) {
            count++;
        }
        innerAuto.setText(count.toString());
    }


    public void submitAuto(View view) {
        Intent teleIntent = new Intent(this, TeleOpActivity.class);
        teleIntent.putExtra("teamMatch" ,this.team);
        teleIntent.putExtra("matchNo", this.matchNo);
        Switch crossed = (Switch) findViewById(R.id.switchCrossed);
        teleIntent.putExtra("Crossed", crossed.isChecked());
        Switch rendes = (Switch) findViewById(R.id.rendevouzSwitch);
        teleIntent.putExtra("Rendevouz", rendes.isChecked());
        Switch trench = (Switch) findViewById(R.id.switchTrench);
        teleIntent.putExtra("Trench", trench.isChecked());
        TextView lowGoals = (TextView) findViewById(R.id.txtLowGoalCountAuto);
        teleIntent.putExtra("LowAuto", Integer.parseInt(lowGoals.getText().toString()));
        TextView highGoals = (TextView) findViewById(R.id.txtHighGoalCountAuto);
        teleIntent.putExtra("HighAuto",Integer.parseInt(highGoals.getText().toString()));
        TextView innerGoals = (TextView) findViewById(R.id.txtCountInnerAuto);
        teleIntent.putExtra("InnerAuto",Integer.parseInt(innerGoals.getText().toString()));
        TextView extraGrab = (TextView) findViewById(R.id.txtExtraCountAuto);
        teleIntent.putExtra("ExtraGrab",Integer.parseInt(extraGrab.getText().toString()));
        EditText autoNotes = (EditText) findViewById(R.id.txtNotesAuto);
        teleIntent.putExtra("AutoNotes", autoNotes.getText().toString());
        startActivity(teleIntent);
        finish();

    }
}