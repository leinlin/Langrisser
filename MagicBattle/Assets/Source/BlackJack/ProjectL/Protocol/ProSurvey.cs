using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200066C RID: 1644
	[ProtoContract(Name = "ProSurvey")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProSurvey : IExtensible
	{
		// Token: 0x060059B4 RID: 22964 RVA: 0x0019E2B8 File Offset: 0x0019C4B8
		public ProSurvey()
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

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x060059B5 RID: 22965 RVA: 0x0019E320 File Offset: 0x0019C520
		// (set) Token: 0x060059B6 RID: 22966 RVA: 0x0019E328 File Offset: 0x0019C528
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x060059B7 RID: 22967 RVA: 0x0019E334 File Offset: 0x0019C534
		// (set) Token: 0x060059B8 RID: 22968 RVA: 0x0019E33C File Offset: 0x0019C53C
		[ProtoMember(2, IsRequired = true, Name = "StartTime", DataFormat = DataFormat.TwosComplement)]
		public long StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				this._StartTime = value;
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x060059B9 RID: 22969 RVA: 0x0019E348 File Offset: 0x0019C548
		// (set) Token: 0x060059BA RID: 22970 RVA: 0x0019E350 File Offset: 0x0019C550
		[ProtoMember(3, IsRequired = true, Name = "EndTime", DataFormat = DataFormat.TwosComplement)]
		public long EndTime
		{
			get
			{
				return this._EndTime;
			}
			set
			{
				this._EndTime = value;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x060059BB RID: 22971 RVA: 0x0019E35C File Offset: 0x0019C55C
		// (set) Token: 0x060059BC RID: 22972 RVA: 0x0019E364 File Offset: 0x0019C564
		[ProtoMember(4, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				this._Status = value;
			}
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x0019E370 File Offset: 0x0019C570
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x0019E380 File Offset: 0x0019C580
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

		// Token: 0x060059BF RID: 22975 RVA: 0x0019E44C File Offset: 0x0019C64C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProSurvey));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400433F RID: 17215
		private int _Id;

		// Token: 0x04004340 RID: 17216
		private long _StartTime;

		// Token: 0x04004341 RID: 17217
		private long _EndTime;

		// Token: 0x04004342 RID: 17218
		private int _Status;

		// Token: 0x04004343 RID: 17219
		private IExtension extensionObject;

		// Token: 0x04004344 RID: 17220
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004345 RID: 17221
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004346 RID: 17222
		private LuaFunction m_ctor_hotfix;
	}
}
