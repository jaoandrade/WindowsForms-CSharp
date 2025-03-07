using System;
using System.IO;
using NAudio.Wave;

public static class AudioManager
{
    private static IWavePlayer backgroundPlayer;
    private static WaveStream backgroundReader;
    private static string[] musicFiles = { "musics (2).wav", "musics (1).wav" }; 
    private static int currentTrackIndex = 0;

    public static void PlayBackgroundMusic(bool loop = true)
    {
        try
        {
            StopBackgroundMusic();

            if (musicFiles.Length == 0)
                throw new InvalidOperationException("Nenhuma música foi configurada na lista de reprodução.");

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, musicFiles[currentTrackIndex]);
            if (!File.Exists(path))
                throw new FileNotFoundException("Arquivo de música não encontrado: " + path);

            var audioFile = new AudioFileReader(path)
            {
                Volume = 0.2f
            };

            if (loop)
            {
                backgroundReader = new LoopStream(audioFile);
            }
            else
            {
                backgroundReader = audioFile;
            }

            backgroundPlayer = new WaveOutEvent();
            backgroundPlayer.Init(backgroundReader);
            backgroundPlayer.Play();
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Erro ao tocar a música de fundo: {ex.Message}",
                "Erro de Áudio", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }

    public static void StopBackgroundMusic()
    {
        if (backgroundPlayer != null)
        {
            backgroundPlayer.Stop();
            backgroundPlayer.Dispose();
            backgroundPlayer = null;

            backgroundReader?.Dispose();
            backgroundReader = null;
        }
    }

    public static void PlayButtonClickSound(string fileName = "button.wav")
    {
        try
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            if (!File.Exists(path))
                throw new FileNotFoundException("Arquivo de som do botão não encontrado: " + path);

            using (var audioFileReader = new AudioFileReader(path))
            using (var waveOut = new WaveOutEvent())
            {
                waveOut.Init(audioFileReader);
                waveOut.Play();
                while (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Erro ao tocar som do botão: {ex.Message}",
                "Erro de Áudio", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }

    public static void NextTrack(bool loop = true)
    {
        try
        {
            currentTrackIndex = (currentTrackIndex + 1) % musicFiles.Length;
            PlayBackgroundMusic(loop);
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Erro ao trocar de música: {ex.Message}",
                "Erro de Áudio", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }

    public static void PreviousTrack(bool loop = true)
    {
        try
        {
            currentTrackIndex = (currentTrackIndex - 1 + musicFiles.Length) % musicFiles.Length;
            PlayBackgroundMusic(loop);
        }
        catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show($"Erro ao voltar para a música anterior: {ex.Message}",
                "Erro de Áudio", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
    public static void PauseBackgroundMusic()
    {
        if (backgroundPlayer != null && backgroundPlayer.PlaybackState == PlaybackState.Playing)
        {
            backgroundPlayer.Pause();
        }
    }

    public static void ResumeBackgroundMusic()
    {
        if (backgroundPlayer != null && backgroundPlayer.PlaybackState == PlaybackState.Paused)
        {
            backgroundPlayer.Play();
        }
    }

}

public class LoopStream : WaveStream
{
    private readonly WaveStream sourceStream;

    public LoopStream(WaveStream sourceStream)
    {
        this.sourceStream = sourceStream;
    }

    public override WaveFormat WaveFormat => sourceStream.WaveFormat;

    public override long Length => long.MaxValue;

    public override long Position
    {
        get => sourceStream.Position;
        set => sourceStream.Position = value;
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        int bytesRead = sourceStream.Read(buffer, offset, count);
        if (bytesRead < count)
        {
            sourceStream.Position = 0;
            bytesRead += sourceStream.Read(buffer, offset + bytesRead, count - bytesRead);
        }
        return bytesRead;
    }
}
