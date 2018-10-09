using System;
using System.IO;

namespace BlackJack.LibClient
{
	// Token: 0x02000869 RID: 2153
	public class MessageBlock
	{
		// Token: 0x06006B08 RID: 27400 RVA: 0x001E06B8 File Offset: 0x001DE8B8
		public MessageBlock(int maxLength)
		{
			this.m_buffer = new byte[maxLength];
			this.m_rdPtr = 0;
			this.m_wrPtr = 0;
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x001E06DC File Offset: 0x001DE8DC
		public int Write(byte[] dataBlock, int dataLen)
		{
			Debug.Assert(dataBlock != null, new object[0]);
			Debug.Assert(dataLen > 0, new object[0]);
			Debug.Assert(dataBlock.Length >= dataLen, new object[0]);
			while (dataLen > this.Space)
			{
				Array.Resize<byte>(ref this.m_buffer, this.m_buffer.Length * 2);
			}
			Array.Copy(dataBlock, 0, this.m_buffer, this.m_wrPtr, dataLen);
			this.m_wrPtr += dataLen;
			return dataLen;
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x001E0768 File Offset: 0x001DE968
		public int ReadInt32()
		{
			int result = BitConverter.ToInt32(this.m_buffer, this.m_rdPtr);
			this.m_rdPtr += 4;
			return result;
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x001E0798 File Offset: 0x001DE998
		public ushort ReadUInt16()
		{
			ushort result = BitConverter.ToUInt16(this.m_buffer, this.m_rdPtr);
			this.m_rdPtr += 2;
			return result;
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x001E07C8 File Offset: 0x001DE9C8
		public int PeekInt32()
		{
			Debug.Assert(this.Length >= 4, new object[0]);
			return BitConverter.ToInt32(this.m_buffer, this.m_rdPtr);
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x001E07F4 File Offset: 0x001DE9F4
		public int ReadPtr(int ahOffset)
		{
			this.m_rdPtr += ahOffset;
			Debug.Assert(this.m_rdPtr >= 0 && this.m_rdPtr <= this.m_wrPtr, new object[0]);
			return this.m_rdPtr;
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x001E0840 File Offset: 0x001DEA40
		public MemoryStream GetReadStream(int dataLen)
		{
			Debug.Assert(dataLen <= this.Length, new object[0]);
			MemoryStream result = new MemoryStream(this.m_buffer, this.m_rdPtr, dataLen, false);
			this.m_rdPtr += dataLen;
			return result;
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x001E0888 File Offset: 0x001DEA88
		public void Crunch()
		{
			if (this.m_rdPtr == 0)
			{
				return;
			}
			if (this.m_rdPtr < this.m_buffer.Length / 5)
			{
				return;
			}
			if (this.Length == 0)
			{
				this.m_rdPtr = 0;
				this.m_wrPtr = 0;
			}
			else
			{
				int length = this.Length;
				Array.Copy(this.m_buffer, this.m_rdPtr, this.m_buffer, 0, length);
				this.m_rdPtr = 0;
				this.m_wrPtr = length;
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06006B10 RID: 27408 RVA: 0x001E0904 File Offset: 0x001DEB04
		public int Length
		{
			get
			{
				return this.m_wrPtr - this.m_rdPtr;
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06006B11 RID: 27409 RVA: 0x001E0914 File Offset: 0x001DEB14
		public int Space
		{
			get
			{
				return this.m_buffer.Length - this.m_wrPtr;
			}
		}

		// Token: 0x04005273 RID: 21107
		private byte[] m_buffer;

		// Token: 0x04005274 RID: 21108
		private int m_rdPtr;

		// Token: 0x04005275 RID: 21109
		private int m_wrPtr;
	}
}
