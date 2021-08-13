using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;
/// <summary>
/// 角色配置
/// </summary>
public class RoleConfigData : DataRowBase
{
    public override int Id { get { return mid; } }

    private int mid;

    /// <summary>
    /// 名称
    /// </summary>
    public string name;
    /// <summary>
    /// hp
    /// </summary>
    public int hp;
    /// <summary>
    /// 最大hp
    /// </summary>
    public int maxHp;
    /// <summary>
    /// 等级
    /// </summary>
    public uint level = 1;
    /// <summary>
    /// 战斗模型资源ID
    /// </summary>
    public string fightModelID;
    /// <summary>
    /// 攻击力
    /// </summary>
    private int attack;
    /// <summary>
    /// 攻击速度
    /// </summary>
    private int attackSpeed;
    /// <summary>
    /// 护甲
    /// </summary>
    private int define;
    /// <summary>
    /// 攻击距离
    /// </summary>
    private int attackDistance;
    /// <summary>
    /// 位置索引
    /// </summary>
    public int posIndex;
    /// <summary>
    /// 下一个技能ID
    /// </summary>
    public uint nextSkillID;
}
