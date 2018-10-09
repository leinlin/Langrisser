using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000689 RID: 1673
	[ProtoContract(Name = "ProHeroPhantomLevel")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProHeroPhantomLevel : IExtensible
	{
		// Token: 0x06005B1E RID: 23326 RVA: 0x001A1D54 File Offset: 0x0019FF54
		public ProHeroPhantomLevel()
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

		// Token: 0x170016FB RID: 5883
		// (get) Token: 0x06005B1F RID: 23327 RVA: 0x001A1DC8 File Offset: 0x0019FFC8
		// (set) Token: 0x06005B20 RID: 23328 RVA: 0x001A1DD0 File Offset: 0x0019FFD0
		[ProtoMember(1, IsRequired = true, Name = "ConfigId", DataFormat = DataFormat.TwosComplement)]
		public int ConfigId
		{
			get
			{
				return this._ConfigId;
			}
			set
			{
				this._ConfigId = value;
			}
		}

		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x06005B21 RID: 23329 RVA: 0x001A1DDC File Offset: 0x0019FFDC
		// (set) Token: 0x06005B22 RID: 23330 RVA: 0x001A1DE4 File Offset: 0x0019FFE4
		[ProtoMember(2, IsRequired = true, Name = "FirstClear", DataFormat = DataFormat.TwosComplement)]
		public long FirstClear
		{
			get
			{
				return this._FirstClear;
			}
			set
			{
				this._FirstClear = value;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06005B23 RID: 23331 RVA: 0x001A1DF0 File Offset: 0x0019FFF0
		[ProtoMember(3, Name = "AchievementsFinished", DataFormat = DataFormat.TwosComplement)]
		public List<int> AchievementsFinished
		{
			get
			{
				return this._AchievementsFinished;
			}
		}

		// Token: 0x06005B24 RID: 23332 RVA: 0x001A1DF8 File Offset: 0x0019FFF8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B25 RID: 23333 RVA: 0x001A1E08 File Offset: 0x001A0008
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

		// Token: 0x06005B26 RID: 23334 RVA: 0x001A1ED4 File Offset: 0x001A00D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroPhantomLevel));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004435 RID: 17461
		private int _ConfigId;

		// Token: 0x04004436 RID: 17462
		private long _FirstClear;

		// Token: 0x04004437 RID: 17463
		private readonly List<int> _AchievementsFinished = new List<int>();

		// Token: 0x04004438 RID: 17464
		private IExtension extensionObject;

		// Token: 0x04004439 RID: 17465
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400443A RID: 17466
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400443B RID: 17467
		private LuaFunction m_ctor_hotfix;
	}
}
