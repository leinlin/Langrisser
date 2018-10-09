using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000772 RID: 1906
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildBasicSetAck")]
	[Serializable]
	public class GuildBasicSetAck : IExtensible
	{
		// Token: 0x060062F5 RID: 25333 RVA: 0x001BD114 File Offset: 0x001BB314
		public GuildBasicSetAck()
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

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060062F6 RID: 25334 RVA: 0x001BD17C File Offset: 0x001BB37C
		// (set) Token: 0x060062F7 RID: 25335 RVA: 0x001BD184 File Offset: 0x001BB384
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060062F8 RID: 25336 RVA: 0x001BD190 File Offset: 0x001BB390
		// (set) Token: 0x060062F9 RID: 25337 RVA: 0x001BD198 File Offset: 0x001BB398
		[ProtoMember(2, IsRequired = true, Name = "AutoJoin", DataFormat = DataFormat.Default)]
		public bool AutoJoin
		{
			get
			{
				return this._AutoJoin;
			}
			set
			{
				this._AutoJoin = value;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060062FA RID: 25338 RVA: 0x001BD1A4 File Offset: 0x001BB3A4
		// (set) Token: 0x060062FB RID: 25339 RVA: 0x001BD1AC File Offset: 0x001BB3AC
		[ProtoMember(3, IsRequired = true, Name = "JoinLevel", DataFormat = DataFormat.TwosComplement)]
		public int JoinLevel
		{
			get
			{
				return this._JoinLevel;
			}
			set
			{
				this._JoinLevel = value;
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060062FC RID: 25340 RVA: 0x001BD1B8 File Offset: 0x001BB3B8
		// (set) Token: 0x060062FD RID: 25341 RVA: 0x001BD1C0 File Offset: 0x001BB3C0
		[ProtoMember(4, IsRequired = true, Name = "HiringDeclaration", DataFormat = DataFormat.Default)]
		public string HiringDeclaration
		{
			get
			{
				return this._HiringDeclaration;
			}
			set
			{
				this._HiringDeclaration = value;
			}
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x001BD1CC File Offset: 0x001BB3CC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062FF RID: 25343 RVA: 0x001BD1DC File Offset: 0x001BB3DC
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

		// Token: 0x06006300 RID: 25344 RVA: 0x001BD2A8 File Offset: 0x001BB4A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildBasicSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A29 RID: 18985
		private int _Result;

		// Token: 0x04004A2A RID: 18986
		private bool _AutoJoin;

		// Token: 0x04004A2B RID: 18987
		private int _JoinLevel;

		// Token: 0x04004A2C RID: 18988
		private string _HiringDeclaration;

		// Token: 0x04004A2D RID: 18989
		private IExtension extensionObject;

		// Token: 0x04004A2E RID: 18990
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A2F RID: 18991
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A30 RID: 18992
		private LuaFunction m_ctor_hotfix;
	}
}
