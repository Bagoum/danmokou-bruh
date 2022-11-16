﻿using Danmokou;
using Danmokou.Achievements;
using Danmokou.Danmaku;
using Danmokou.GameInstance;
using UnityEngine;

namespace BRuH {
[CreateAssetMenu(menuName = "Data/GameDef/BRuH")]
public class BRuHGameDef : SceneDanmakuGameDef {

    public override InstanceFeatures MakeFeatures(DifficultySettings d, long? highScore) => new() {
        Score = new ScoreFeatureCreator(highScore),
        Power = new DisabledPowerFeatureCreator(),
        Faith = new FaithFeatureCreator(),
        ItemExt = new LifeItemExtendFeatureCreator(),
        Rank = new DisabledRankFeatureCreator(),
        ScoreExt = new ScoreExtendFeatureCreator(),
        Meter = new MeterFeatureCreator()
    };
}
}