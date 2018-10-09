using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200066E RID: 1646
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProTurnDanmaku")]
	[Serializable]
	public class ProTurnDanmaku : IExtensible
	{
		// Token: 0x060059C5 RID: 22981 RVA: 0x0019E674 File Offset: 0x0019C874
		public ProTurnDanmaku()
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

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x060059C6 RID: 22982 RVA: 0x0019E6E8 File Offset: 0x0019C8E8
		// (set) Token: 0x060059C7 RID: 22983 RVA: 0x0019E6F0 File Offset: 0x0019C8F0
		[ProtoMember(1, IsRequired = true, Name = "Turn", DataFormat = DataFormat.TwosComplement)]
		public int Turn
		{
			get
			{
				return this._Turn;
			}
			set
			{
				this._Turn = value;
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x060059C8 RID: 22984 RVA: 0x0019E6FC File Offset: 0x0019C8FC
		// (set) Token: 0x060059C9 RID: 22985 RVA: 0x0019E704 File Offset: 0x0019C904
		[ProtoMember(2, IsRequired = true, Name = "NextIndex", DataFormat = DataFormat.TwosComplement)]
		public int NextIndex
		{
			get
			{
				return this._NextIndex;
			}
			set
			{
				this._NextIndex = value;
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x060059CA RID: 22986 RVA: 0x0019E710 File Offset: 0x0019C910
		[ProtoMember(3, Name = "Entries", DataFormat = DataFormat.Default)]
		public List<ProDanmakuEntry> Entries
		{
			get
			{
				return this._Entries;
			}
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x0019E718 File Offset: 0x0019C918
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x0019E728 File Offset: 0x0019C928
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

		// Token: 0x060059CD RID: 22989 RVA: 0x0019E7F4 File Offset: 0x0019C9F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProTurnDanmaku));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400434C RID: 17228
		private int _Turn;

		// Token: 0x0400434D RID: 17229
		private int _NextIndex;

		// Token: 0x0400434E RID: 17230
		private readonly List<ProDanmakuEntry> _Entries = new List<ProDanmakuEntry>();

		// Token: 0x0400434F RID: 17231
		private IExtension extensionObject;

		// Token: 0x04004350 RID: 17232
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004351 RID: 17233
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004352 RID: 17234
		private LuaFunction m_ctor_hotfix;
	}
}
