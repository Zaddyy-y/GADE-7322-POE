using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundGenerator : MonoBehaviour
{
    private float waveValue;
    private float nextWavePhase;
    private float waveSample;
    private float wavePhase;
   [SerializeField] public float waveFrequency = 261.62f;
   [SerializeField, Range (0,1)] public float waveAmplitude = 0.5f;
    private int frequencyIndex = 0;
    private string[] frequency = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };  
    private float[] frequencyDurations = { 0.5f, 0.5f, 0.5f, 0.5f, 1f, 1f, 0.5f, 0.5f, 1f, 1f };  
    private float playNextFrequency;
    private bool isPlaying = false;
    public string temp;
    public float temp2;
    

    private void Awake()
    {
        waveSample = AudioSettings.outputSampleRate; // Set waveSample to the current audio output sample rate to ensure sin waves play at the correct pitch and speed
    }

    private void Start()
    {
        for (int i = 0; i < frequency.Length; i++)
        {
            int randomFrequencyIndex = UnityEngine.Random.Range (i, frequency.Length); // Fetches a random index in the frequency array
            temp = frequency[i]; //temp stores the randomly selected element at index i
            frequency[i] = frequency[randomFrequencyIndex]; //Element at randomfrequencyindex is moved to the position of i
            frequency[randomFrequencyIndex] = temp; //Element at i is moved to the position of randomfrequencyindex
        }

        for (int i = 0; i < frequencyDurations.Length; i++)
        {
            int randomDurationIndex = UnityEngine.Random.Range(i, frequencyDurations.Length); //Same as above just for the frequencyduration array
            temp2 = frequencyDurations[i];
            frequencyDurations[i] = frequencyDurations[randomDurationIndex];
            frequencyDurations[randomDurationIndex] = temp2;
        }

        playNextFrequency = Time.time; //Next frequency's start time = current time
        StartCoroutine(GenerateMusic());
    }

    private void OnAudioFilterRead(float[] data, int channels)
    {
        nextWavePhase = waveFrequency / waveSample; // Generates the next wavephase based on the current wave frequency divided by the current wave sample

        for (int i = 0; i < data.Length; i+= channels) // Accounting for both stereo and mono channels
        {
            waveValue = Mathf.Sin((float) wavePhase * 2 *Mathf.PI) * waveAmplitude; // Generates the sine wave value using the current wave phase, multiplying it by the specified amplitude
            wavePhase = (wavePhase + nextWavePhase) % 1;  // Incrementing the wavephase till 1 to keep it cycling

            for (int j = 0; j < channels; j++) // Writes the wave value to both stereo and mono channels
            {
                data[i + j] = waveValue; // Sets the wave value to be the same for both left and right channels

            }
        }

       
    }

    IEnumerator GenerateMusic()
    {
        while (frequencyIndex < frequency.Length)
        {
            // Get the frequency for the current note
            waveFrequency = Frequencies.Frequency(frequency[frequencyIndex]); //Fetches the current frequency

            // Wait for the duration of the current note
            float frequencyDuration = frequencyDurations[frequencyIndex];
            playNextFrequency = Time.time + frequencyDuration; //Waits for the specified duration

            
            isPlaying = true;
            while (Time.time < playNextFrequency)
            {
                yield return null; //Plays the frequencies as long as there is a next frequency to play
            }

           
            frequencyIndex++; //Moves on to the next frequency
        }
    }
}
