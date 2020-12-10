using SoundViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    class SoundViewer
    {
        private WaveInRecorder _recorder;
        private byte[] _recorderBuffer;
        private WaveOutPlayer _player;
        private byte[] _playerBuffer;
        private FifoStream _stream;
        private WaveFormat _waveFormat;
        private AudioFrame _audioFrame;
        private int _audioSamplesPerSecond = 44100;
        private int _audioFrameSize = 16384;
        private byte _audioBitsPerSample = 16;
        private byte _audioChannels = 1;
        private bool _isPlayer = false;
        private bool _isTest = false;
        private PictureBox PictureBox;

        public SoundViewer(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }

        public void Draw()
        {
            if (WaveNative.waveInGetNumDevs() > 0)
            {
                if (_isPlayer == true)
                    _stream = new FifoStream();
                _audioFrame = new AudioFrame(_isTest);
                Start();
            }
        }

        private void Start()
        {
            Stop();
            try
            {
                _waveFormat = new WaveFormat(_audioFrameSize, _audioBitsPerSample, _audioChannels);
                _recorder = new WaveInRecorder(0, _waveFormat, _audioFrameSize * 2, 3, new BufferDoneEventHandler(DataArrived));
                if (_isPlayer == true)
                    _player = new WaveOutPlayer(-1, _waveFormat, _audioFrameSize * 2, 3, new BufferFillEventHandler(Filler));
            }
            catch (Exception ex)
            {
            }
        }

        private void Stop()
        {
            if (_recorder != null)
                try
                {
                    _recorder.Dispose();
                }
                finally
                {
                    _recorder = null;
                }
            if (_isPlayer == true)
            {
                if (_player != null)
                    try
                    {
                        _player.Dispose();
                    }
                    finally
                    {
                        _player = null;
                    }
                _stream.Flush(); // clear all pending data
            }
        }


        private void Filler(IntPtr data, int size)
        {
            if (_isPlayer == true)
            {
                if (_playerBuffer == null || _playerBuffer.Length < size)
                    _playerBuffer = new byte[size];
                if (_stream.Length >= size)
                    _stream.Read(_playerBuffer, 0, size);
                else
                    for (int i = 0; i < _playerBuffer.Length; i++)
                        _playerBuffer[i] = 0;
                System.Runtime.InteropServices.Marshal.Copy(_playerBuffer, 0, data, size);
            }
        }

        private void DataArrived(IntPtr data, int size)
        {
            if (_recorderBuffer == null || _recorderBuffer.Length < size)
                _recorderBuffer = new byte[size];
            if (_recorderBuffer != null)
            {
                System.Runtime.InteropServices.Marshal.Copy(data, _recorderBuffer, 0, size);
                if (_isPlayer == true)
                    _stream.Write(_recorderBuffer, 0, _recorderBuffer.Length);
                _audioFrame.Process(ref _recorderBuffer);
                _audioFrame.RenderTimeDomain(ref PictureBox);
                _audioFrame.RenderFrequencyDomain(ref PictureBox);
            }
        }
    }
}
