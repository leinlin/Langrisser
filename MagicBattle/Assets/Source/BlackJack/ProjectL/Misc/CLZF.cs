using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000F8A RID: 3978
	[HotFix]
	public class CLZF
	{
		// Token: 0x06013ECA RID: 81610 RVA: 0x00512C74 File Offset: 0x00510E74
		public CLZF()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06013ECB RID: 81611 RVA: 0x00512CDC File Offset: 0x00510EDC
		public static byte[] Compress(byte[] inputBytes)
		{
			if (inputBytes == null || inputBytes.Length == 0)
			{
				return null;
			}
			int num = inputBytes.Length * 2;
			byte[] src = new byte[num];
			int num2;
			for (num2 = CLZF.lzf_compress(inputBytes, ref src); num2 == 0; num2 = CLZF.lzf_compress(inputBytes, ref src))
			{
				num *= 2;
				src = new byte[num];
			}
			byte[] array = new byte[num2];
			Buffer.BlockCopy(src, 0, array, 0, num2);
			return array;
		}

		// Token: 0x06013ECC RID: 81612 RVA: 0x00512D40 File Offset: 0x00510F40
		public static byte[] Decompress(byte[] inputBytes)
		{
			int num = inputBytes.Length * 2;
			byte[] src = new byte[num];
			int num2;
			for (num2 = CLZF.lzf_decompress(inputBytes, ref src); num2 == 0; num2 = CLZF.lzf_decompress(inputBytes, ref src))
			{
				num *= 2;
				src = new byte[num];
			}
			byte[] array = new byte[num2];
			Buffer.BlockCopy(src, 0, array, 0, num2);
			return array;
		}

		// Token: 0x06013ECD RID: 81613 RVA: 0x00512D94 File Offset: 0x00510F94
		public static int lzf_compress(byte[] input, ref byte[] output)
		{
			int num = input.Length;
			int num2 = output.Length;
			Array.Clear(CLZF.HashTable, 0, (int)CLZF.HSIZE);
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = (uint)((int)input[(int)((UIntPtr)num3)] << 8 | (int)input[(int)((UIntPtr)(num3 + 1u))]);
			int num6 = 0;
			for (;;)
			{
				if ((ulong)num3 < (ulong)((long)(num - 2)))
				{
					num5 = (num5 << 8 | (uint)input[(int)((UIntPtr)(num3 + 2u))]);
					long num7 = (long)((ulong)((num5 ^ num5 << 5) >> (int)(24u - CLZF.HLOG - num5 * 5u) & CLZF.HSIZE - 1u));
					long num8 = CLZF.HashTable[(int)(checked((IntPtr)num7))];
					CLZF.HashTable[(int)(checked((IntPtr)num7))] = (long)((ulong)num3);
					long num9;
					if ((num9 = (long)((ulong)num3 - (ulong)num8 - 1UL)) < (long)((ulong)CLZF.MAX_OFF) && (ulong)(num3 + 4u) < (ulong)((long)num) && num8 > 0L && input[(int)(checked((IntPtr)num8))] == input[(int)((UIntPtr)num3)] && input[(int)(checked((IntPtr)(unchecked(num8 + 1L))))] == input[(int)((UIntPtr)(num3 + 1u))] && input[(int)(checked((IntPtr)(unchecked(num8 + 2L))))] == input[(int)((UIntPtr)(num3 + 2u))])
					{
						uint num10 = 2u;
						uint num11 = (uint)(num - (int)num3 - (int)num10);
						num11 = ((num11 <= CLZF.MAX_REF) ? num11 : CLZF.MAX_REF);
						if ((ulong)num4 + (ulong)((long)num6) + 1UL + 3UL >= (ulong)((long)num2))
						{
							break;
						}
						do
						{
							num10 += 1u;
						}
						while (num10 < num11 && input[(int)(checked((IntPtr)(unchecked(num8 + (long)((ulong)num10)))))] == input[(int)((UIntPtr)(num3 + num10))]);
						if (num6 != 0)
						{
							output[(int)((UIntPtr)(num4++))] = (byte)(num6 - 1);
							num6 = -num6;
							do
							{
								output[(int)((UIntPtr)(num4++))] = input[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num6)))))];
							}
							while (++num6 != 0);
						}
						num10 -= 2u;
						num3 += 1u;
						if (num10 < 7u)
						{
							output[(int)((UIntPtr)(num4++))] = (byte)((num9 >> 8) + (long)((ulong)((ulong)num10 << 5)));
						}
						else
						{
							output[(int)((UIntPtr)(num4++))] = (byte)((num9 >> 8) + 224L);
							output[(int)((UIntPtr)(num4++))] = (byte)(num10 - 7u);
						}
						output[(int)((UIntPtr)(num4++))] = (byte)num9;
						num3 += num10 - 1u;
						num5 = (uint)((int)input[(int)((UIntPtr)num3)] << 8 | (int)input[(int)((UIntPtr)(num3 + 1u))]);
						num5 = (num5 << 8 | (uint)input[(int)((UIntPtr)(num3 + 2u))]);
						CLZF.HashTable[(int)((UIntPtr)((num5 ^ num5 << 5) >> (int)(24u - CLZF.HLOG - num5 * 5u) & CLZF.HSIZE - 1u))] = (long)((ulong)num3);
						num3 += 1u;
						num5 = (num5 << 8 | (uint)input[(int)((UIntPtr)(num3 + 2u))]);
						CLZF.HashTable[(int)((UIntPtr)((num5 ^ num5 << 5) >> (int)(24u - CLZF.HLOG - num5 * 5u) & CLZF.HSIZE - 1u))] = (long)((ulong)num3);
						num3 += 1u;
						continue;
					}
				}
				else if ((ulong)num3 == (ulong)((long)num))
				{
					goto Block_13;
				}
				num6++;
				num3 += 1u;
				if ((long)num6 == (long)((ulong)CLZF.MAX_LIT))
				{
					if ((ulong)(num4 + 1u + CLZF.MAX_LIT) >= (ulong)((long)num2))
					{
						return 0;
					}
					output[(int)((UIntPtr)(num4++))] = (byte)(CLZF.MAX_LIT - 1u);
					num6 = -num6;
					do
					{
						output[(int)((UIntPtr)(num4++))] = input[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num6)))))];
					}
					while (++num6 != 0);
				}
			}
			return 0;
			Block_13:
			if (num6 != 0)
			{
				if ((ulong)num4 + (ulong)((long)num6) + 1UL >= (ulong)((long)num2))
				{
					return 0;
				}
				output[(int)((UIntPtr)(num4++))] = (byte)(num6 - 1);
				num6 = -num6;
				do
				{
					output[(int)((UIntPtr)(num4++))] = input[(int)(checked((IntPtr)(unchecked((ulong)num3 + (ulong)((long)num6)))))];
				}
				while (++num6 != 0);
			}
			return (int)num4;
		}

		// Token: 0x06013ECE RID: 81614 RVA: 0x005130DC File Offset: 0x005112DC
		public static int lzf_decompress(byte[] input, ref byte[] output)
		{
			int num = input.Length;
			int num2 = output.Length;
			uint num3 = 0u;
			uint num4 = 0u;
			for (;;)
			{
				uint num5 = (uint)input[(int)((UIntPtr)(num3++))];
				if (num5 < 32u)
				{
					num5 += 1u;
					if ((ulong)(num4 + num5) > (ulong)((long)num2))
					{
						break;
					}
					do
					{
						output[(int)((UIntPtr)(num4++))] = input[(int)((UIntPtr)(num3++))];
					}
					while ((num5 -= 1u) != 0u);
				}
				else
				{
					uint num6 = num5 >> 5;
					int num7 = (int)(num4 - ((num5 & 31u) << 8) - 1u);
					if (num6 == 7u)
					{
						num6 += (uint)input[(int)((UIntPtr)(num3++))];
					}
					num7 -= (int)input[(int)((UIntPtr)(num3++))];
					if ((ulong)(num4 + num6 + 2u) > (ulong)((long)num2))
					{
						return 0;
					}
					if (num7 < 0)
					{
						return 0;
					}
					output[(int)((UIntPtr)(num4++))] = output[num7++];
					output[(int)((UIntPtr)(num4++))] = output[num7++];
					do
					{
						output[(int)((UIntPtr)(num4++))] = output[num7++];
					}
					while ((num6 -= 1u) != 0u);
				}
				if ((ulong)num3 >= (ulong)((long)num))
				{
					return (int)num4;
				}
			}
			return 0;
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x06013ECF RID: 81615 RVA: 0x005131E0 File Offset: 0x005113E0
		// (set) Token: 0x06013ED0 RID: 81616 RVA: 0x00513200 File Offset: 0x00511400
		[DoNotToLua]
		public CLZF.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CLZF.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06013ED2 RID: 81618 RVA: 0x0051324C File Offset: 0x0051144C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06013ED3 RID: 81619 RVA: 0x00513318 File Offset: 0x00511518
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CLZF));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400AFFD RID: 45053
		private static readonly uint HLOG = 14u;

		// Token: 0x0400AFFE RID: 45054
		private static readonly uint HSIZE = 16384u;

		// Token: 0x0400AFFF RID: 45055
		private static readonly uint MAX_LIT = 32u;

		// Token: 0x0400B000 RID: 45056
		private static readonly uint MAX_OFF = 8192u;

		// Token: 0x0400B001 RID: 45057
		private static readonly uint MAX_REF = 264u;

		// Token: 0x0400B002 RID: 45058
		private static readonly long[] HashTable = new long[CLZF.HSIZE];

		// Token: 0x0400B003 RID: 45059
		[DoNotToLua]
		private CLZF.LuaExportHelper luaExportHelper;

		// Token: 0x0400B004 RID: 45060
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B005 RID: 45061
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B006 RID: 45062
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000F8B RID: 3979
		public class LuaExportHelper
		{
			// Token: 0x06013ED4 RID: 81620 RVA: 0x00513380 File Offset: 0x00511580
			public LuaExportHelper(CLZF owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17003B7B RID: 15227
			// (get) Token: 0x06013ED5 RID: 81621 RVA: 0x00513390 File Offset: 0x00511590
			public static uint HLOG
			{
				get
				{
					return CLZF.HLOG;
				}
			}

			// Token: 0x17003B7C RID: 15228
			// (get) Token: 0x06013ED6 RID: 81622 RVA: 0x00513398 File Offset: 0x00511598
			public static uint HSIZE
			{
				get
				{
					return CLZF.HSIZE;
				}
			}

			// Token: 0x17003B7D RID: 15229
			// (get) Token: 0x06013ED7 RID: 81623 RVA: 0x005133A0 File Offset: 0x005115A0
			public static uint MAX_LIT
			{
				get
				{
					return CLZF.MAX_LIT;
				}
			}

			// Token: 0x17003B7E RID: 15230
			// (get) Token: 0x06013ED8 RID: 81624 RVA: 0x005133A8 File Offset: 0x005115A8
			public static uint MAX_OFF
			{
				get
				{
					return CLZF.MAX_OFF;
				}
			}

			// Token: 0x17003B7F RID: 15231
			// (get) Token: 0x06013ED9 RID: 81625 RVA: 0x005133B0 File Offset: 0x005115B0
			public static uint MAX_REF
			{
				get
				{
					return CLZF.MAX_REF;
				}
			}

			// Token: 0x17003B80 RID: 15232
			// (get) Token: 0x06013EDA RID: 81626 RVA: 0x005133B8 File Offset: 0x005115B8
			public static long[] HashTable
			{
				get
				{
					return CLZF.HashTable;
				}
			}

			// Token: 0x0400B007 RID: 45063
			private CLZF m_owner;
		}
	}
}
