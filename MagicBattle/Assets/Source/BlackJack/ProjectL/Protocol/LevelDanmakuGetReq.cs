using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006B4 RID: 1716
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "LevelDanmakuGetReq")]
	[Serializable]
	public class LevelDanmakuGetReq : IExtensible
	{
		// Token: 0x06005CF0 RID: 23792 RVA: 0x001A71D4 File Offset: 0x001A53D4
		public LevelDanmakuGetReq()
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

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06005CF1 RID: 23793 RVA: 0x001A723C File Offset: 0x001A543C
		// (set) Token: 0x06005CF2 RID: 23794 RVA: 0x001A7244 File Offset: 0x001A5444
		[ProtoMember(1, IsRequired = true, Name = "GameFunctionTypeId", DataFormat = DataFormat.TwosComplement)]
		public int GameFunctionTypeId
		{
			get
			{
				return this._GameFunctionTypeId;
			}
			set
			{
				this._GameFunctionTypeId = value;
			}
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x06005CF3 RID: 23795 RVA: 0x001A7250 File Offset: 0x001A5450
		// (set) Token: 0x06005CF4 RID: 23796 RVA: 0x001A7258 File Offset: 0x001A5458
		[ProtoMember(2, IsRequired = true, Name = "LocationId", DataFormat = DataFormat.TwosComplement)]
		public int LocationId
		{
			get
			{
				return this._LocationId;
			}
			set
			{
				this._LocationId = value;
			}
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x001A7264 File Offset: 0x001A5464
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x001A7274 File Offset: 0x001A5474
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

		// Token: 0x06005CF7 RID: 23799 RVA: 0x001A7340 File Offset: 0x001A5540
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LevelDanmakuGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004584 RID: 17796
		private int _GameFunctionTypeId;

		// Token: 0x04004585 RID: 17797
		private int _LocationId;

		// Token: 0x04004586 RID: 17798
		private IExtension extensionObject;

		// Token: 0x04004587 RID: 17799
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004588 RID: 17800
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004589 RID: 17801
		private LuaFunction m_ctor_hotfix;
	}
}
