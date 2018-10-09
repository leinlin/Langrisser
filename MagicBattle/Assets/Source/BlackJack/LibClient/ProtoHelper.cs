using System;
using System.IO;
using BlackJack.LibClient.Protocol;
using ProtoBuf.Meta;
using QuickLZSharp;

namespace BlackJack.LibClient
{
	// Token: 0x0200086B RID: 2155
	public static class ProtoHelper
	{
		// Token: 0x06006B13 RID: 27411 RVA: 0x001E0934 File Offset: 0x001DEB34
		public static object DecodeMessage(MessageBlock recvBuffer, IProtoProvider protoProvider, out int msgId, Func<Stream, Type, int, object> deserializeMessageAction = null)
		{
			int num = 4;
			msgId = 0;
			if (recvBuffer.Length < num)
			{
				return null;
			}
			ushort num2 = recvBuffer.ReadUInt16();
			if ((int)num2 < num)
			{
				throw new ProtoException(string.Format("Hack stream, TotalLength={0}", num2));
			}
			int num3 = (int)num2 - num;
			if (recvBuffer.Length < num3 + 2)
			{
				recvBuffer.ReadPtr(-2);
				return null;
			}
			ushort num4 = recvBuffer.ReadUInt16();
			bool flag = num4 >> 15 == 1;
			ushort num5 = num4 & 32767;
			msgId = (int)num5;
			Type typeById = protoProvider.GetTypeById((int)num5);
			object result;
			try
			{
				if (flag)
				{
					using (MemoryStream readStream = recvBuffer.GetReadStream(num3))
					{
						byte[] array = QuickLZ.decompress(readStream.ToArray());
						int count = array.Length;
						using (MemoryStream memoryStream = new MemoryStream(array, 0, count))
						{
							if (deserializeMessageAction != null)
							{
								result = deserializeMessageAction(memoryStream, typeById, msgId);
							}
							else
							{
								result = RuntimeTypeModel.Default.Deserialize(memoryStream, null, typeById, null);
							}
						}
					}
				}
				else
				{
					using (MemoryStream readStream2 = recvBuffer.GetReadStream(num3))
					{
						if (deserializeMessageAction != null)
						{
							result = deserializeMessageAction(readStream2, typeById, msgId);
						}
						else
						{
							result = RuntimeTypeModel.Default.Deserialize(readStream2, null, typeById, null);
						}
					}
				}
			}
			catch (Exception innerException)
			{
				throw new Exception(string.Format("msgId={0}, isCompressed={1} pakBodyLength={2}", msgId, flag, num3), innerException);
			}
			return result;
		}

		// Token: 0x06006B14 RID: 27412 RVA: 0x001E0AF0 File Offset: 0x001DECF0
		public static ArraySegment<byte> EncodeMessage(object vMsg, IProtoProvider protoProvider)
		{
			byte[] array = new byte[65536];
			MemoryStream memoryStream = new MemoryStream(array);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			binaryWriter.Write(0);
			binaryWriter.Write(0);
			RuntimeTypeModel.Default.Serialize(memoryStream, vMsg, null);
			bool flag = memoryStream.Position - 4L >= 400L;
			ushort num;
			if (flag)
			{
				using (MemoryStream memoryStream2 = new MemoryStream(memoryStream.ToArray(), 4, (int)memoryStream.Position - 4))
				{
					byte[] array2 = QuickLZ.compress(memoryStream2.ToArray(), 3);
					memoryStream.Seek(4L, SeekOrigin.Begin);
					memoryStream.Write(array2, 0, array2.Length);
				}
				num = (ushort)memoryStream.Position;
				binaryWriter.Seek(0, SeekOrigin.Begin);
				binaryWriter.Write(num);
				ushort num2 = (ushort)protoProvider.GetIdByType(vMsg.GetType());
				num2 |= 32768;
				binaryWriter.Write(num2);
			}
			else
			{
				num = (ushort)memoryStream.Position;
				binaryWriter.Seek(0, SeekOrigin.Begin);
				binaryWriter.Write(num);
				ushort num3 = (ushort)protoProvider.GetIdByType(vMsg.GetType());
				num3 &= 32767;
				binaryWriter.Write(num3);
			}
			return new ArraySegment<byte>(array, 0, (int)num);
		}
	}
}
