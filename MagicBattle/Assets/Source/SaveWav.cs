using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

// Token: 0x020010D2 RID: 4306
public static class SaveWav
{
	// Token: 0x06015970 RID: 88432 RVA: 0x0057FBB0 File Offset: 0x0057DDB0
	public static bool Save(string filename, AudioClip clip)
	{
		global::Debug.Log(string.Format("SaveWav filename={0} samples={1} frequency={2} channels={3} length={4}", new object[]
		{
			filename,
			clip.samples,
			clip.frequency,
			clip.channels,
			clip.length
		}));
		if (!filename.ToLower().EndsWith(".wav"))
		{
			filename += ".wav";
		}
		Directory.CreateDirectory(Path.GetDirectoryName(filename));
		using (FileStream fileStream = SaveWav.CreateEmpty(filename))
		{
			SaveWav.ConvertAndWrite(fileStream, clip);
			SaveWav.WriteHeader(fileStream, clip);
		}
		return true;
	}

	// Token: 0x06015971 RID: 88433 RVA: 0x0057FC74 File Offset: 0x0057DE74
	public static AudioClip TrimSilence(AudioClip clip, float min)
	{
		float[] array = new float[clip.samples];
		clip.GetData(array, 0);
		return SaveWav.TrimSilence(new List<float>(array), min, clip.channels, clip.frequency);
	}

	// Token: 0x06015972 RID: 88434 RVA: 0x0057FCB0 File Offset: 0x0057DEB0
	public static AudioClip TrimSilence(List<float> samples, float min, int channels, int hz)
	{
		return SaveWav.TrimSilence(samples, min, channels, hz, false, false);
	}

	// Token: 0x06015973 RID: 88435 RVA: 0x0057FCC0 File Offset: 0x0057DEC0
	public static AudioClip TrimSilence(List<float> samples, float min, int channels, int hz, bool _3D, bool stream)
	{
		int i;
		for (i = 0; i < samples.Count; i++)
		{
			if (Mathf.Abs(samples[i]) > min)
			{
				break;
			}
		}
		samples.RemoveRange(0, i);
		for (i = samples.Count - 1; i > 0; i--)
		{
			if (Mathf.Abs(samples[i]) > min)
			{
				break;
			}
		}
		samples.RemoveRange(i, samples.Count - i);
		AudioClip audioClip = AudioClip.Create("TempClip", samples.Count, channels, hz, stream);
		audioClip.SetData(samples.ToArray(), 0);
		return audioClip;
	}

	// Token: 0x06015974 RID: 88436 RVA: 0x0057FD68 File Offset: 0x0057DF68
	private static FileStream CreateEmpty(string filepath)
	{
		FileStream fileStream = new FileStream(filepath, FileMode.Create);
		byte value = 0;
		for (int i = 0; i < 44; i++)
		{
			fileStream.WriteByte(value);
		}
		return fileStream;
	}

	// Token: 0x06015975 RID: 88437 RVA: 0x0057FD9C File Offset: 0x0057DF9C
	private static void ConvertAndWrite(FileStream fileStream, AudioClip clip)
	{
		float[] array = new float[clip.samples];
		clip.GetData(array, 0);
		short[] array2 = new short[array.Length];
		byte[] array3 = new byte[array.Length * 2];
		int num = 32767;
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (short)(array[i] * (float)num);
			byte[] array4 = new byte[2];
			array4 = BitConverter.GetBytes(array2[i]);
			array4.CopyTo(array3, i * 2);
		}
		fileStream.Write(array3, 0, array3.Length);
	}

	// Token: 0x06015976 RID: 88438 RVA: 0x0057FE28 File Offset: 0x0057E028
	private static void WriteHeader(FileStream fileStream, AudioClip clip)
	{
		int frequency = clip.frequency;
		int channels = clip.channels;
		int samples = clip.samples;
		fileStream.Seek(0L, SeekOrigin.Begin);
		byte[] bytes = Encoding.UTF8.GetBytes("RIFF");
		fileStream.Write(bytes, 0, 4);
		byte[] bytes2 = BitConverter.GetBytes(fileStream.Length - 8L);
		fileStream.Write(bytes2, 0, 4);
		byte[] bytes3 = Encoding.UTF8.GetBytes("WAVE");
		fileStream.Write(bytes3, 0, 4);
		byte[] bytes4 = Encoding.UTF8.GetBytes("fmt ");
		fileStream.Write(bytes4, 0, 4);
		byte[] bytes5 = BitConverter.GetBytes(16);
		fileStream.Write(bytes5, 0, 4);
		ushort value = 1;
		byte[] bytes6 = BitConverter.GetBytes(value);
		fileStream.Write(bytes6, 0, 2);
		byte[] bytes7 = BitConverter.GetBytes(channels);
		fileStream.Write(bytes7, 0, 2);
		byte[] bytes8 = BitConverter.GetBytes(frequency);
		fileStream.Write(bytes8, 0, 4);
		byte[] bytes9 = BitConverter.GetBytes(frequency * channels * 2);
		fileStream.Write(bytes9, 0, 4);
		ushort value2 = (ushort)(channels * 2);
		fileStream.Write(BitConverter.GetBytes(value2), 0, 2);
		ushort value3 = 16;
		byte[] bytes10 = BitConverter.GetBytes(value3);
		fileStream.Write(bytes10, 0, 2);
		byte[] bytes11 = Encoding.UTF8.GetBytes("data");
		fileStream.Write(bytes11, 0, 4);
		byte[] bytes12 = BitConverter.GetBytes(samples * channels * 2);
		fileStream.Write(bytes12, 0, 4);
	}

	// Token: 0x0400BCAC RID: 48300
	private const int HEADER_SIZE = 44;
}
