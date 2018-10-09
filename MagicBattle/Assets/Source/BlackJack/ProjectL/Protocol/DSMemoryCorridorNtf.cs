using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200072B RID: 1835
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSMemoryCorridorNtf")]
	[Serializable]
	public class DSMemoryCorridorNtf : IExtensible
	{
		// Token: 0x060060CC RID: 24780 RVA: 0x001B4EE4 File Offset: 0x001B30E4
		public DSMemoryCorridorNtf()
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

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x001B4F58 File Offset: 0x001B3158
		// (set) Token: 0x060060CE RID: 24782 RVA: 0x001B4F60 File Offset: 0x001B3160
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x001B4F6C File Offset: 0x001B316C
		[ProtoMember(2, Name = "FinishedLeves", DataFormat = DataFormat.TwosComplement)]
		public List<int> FinishedLeves
		{
			get
			{
				return this._FinishedLeves;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x060060D0 RID: 24784 RVA: 0x001B4F74 File Offset: 0x001B3174
		// (set) Token: 0x060060D1 RID: 24785 RVA: 0x001B4F7C File Offset: 0x001B317C
		[ProtoMember(3, IsRequired = true, Name = "ChallengedNums", DataFormat = DataFormat.TwosComplement)]
		public int ChallengedNums
		{
			get
			{
				return this._ChallengedNums;
			}
			set
			{
				this._ChallengedNums = value;
			}
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x001B4F88 File Offset: 0x001B3188
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x001B4F98 File Offset: 0x001B3198
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

		// Token: 0x060060D4 RID: 24788 RVA: 0x001B5064 File Offset: 0x001B3264
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSMemoryCorridorNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400487B RID: 18555
		private uint _Version;

		// Token: 0x0400487C RID: 18556
		private readonly List<int> _FinishedLeves = new List<int>();

		// Token: 0x0400487D RID: 18557
		private int _ChallengedNums;

		// Token: 0x0400487E RID: 18558
		private IExtension extensionObject;

		// Token: 0x0400487F RID: 18559
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004880 RID: 18560
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004881 RID: 18561
		private LuaFunction m_ctor_hotfix;
	}
}
