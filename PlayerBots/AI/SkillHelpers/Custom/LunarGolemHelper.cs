﻿using RoR2;
using RoR2.CharacterAI;
using UnityEngine;

namespace PlayerBots.AI.SkillHelpers
{
    [SkillHelperSurvivor("Lunar Golem Survivor")]
    [CustomSurvivor("https://thunderstore.io/package/LuaFubuki/Lunar_Golem/", "0.0.8")]
    class LunarGolemHelper : AiSkillHelper
    {
        public override void InjectSkills(GameObject gameObject, BaseAI ai)
        {
            AISkillDriver skill3_chase = gameObject.AddComponent<AISkillDriver>() as AISkillDriver;
            skill3_chase.customName = "UtilityChase";
            skill3_chase.skillSlot = RoR2.SkillSlot.Utility;
            skill3_chase.requireSkillReady = true;
            skill3_chase.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            skill3_chase.minDistance = 50;
            skill3_chase.maxDistance = 120;
            skill3_chase.selectionRequiresTargetLoS = true;
            skill3_chase.activationRequiresTargetLoS = true;
            skill3_chase.activationRequiresAimConfirmation = false;
            skill3_chase.movementType = AISkillDriver.MovementType.ChaseMoveTarget;
            skill3_chase.aimType = AISkillDriver.AimType.MoveDirection;
            skill3_chase.ignoreNodeGraph = false;
            skill3_chase.resetCurrentEnemyOnNextDriverSelection = false;
            skill3_chase.noRepeat = false;
            skill3_chase.shouldSprint = true;

            AISkillDriver skill3 = gameObject.AddComponent<AISkillDriver>() as AISkillDriver;
            skill3.customName = "Utility";
            skill3.skillSlot = RoR2.SkillSlot.Utility;
            skill3.requireSkillReady = true;
            skill3.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            skill3.minDistance = 0;
            skill3.maxDistance = 20;
            //skill3.maxUserHealthFraction = .25f;
            skill3.selectionRequiresTargetLoS = true;
            skill3.activationRequiresTargetLoS = false;
            skill3.activationRequiresAimConfirmation = false;
            skill3.movementType = AISkillDriver.MovementType.FleeMoveTarget;
            skill3.aimType = AISkillDriver.AimType.MoveDirection;
            skill3.ignoreNodeGraph = false;
            skill3.resetCurrentEnemyOnNextDriverSelection = false;
            skill3.noRepeat = false;
            skill3.shouldSprint = true;
            skill3.buttonPressType = AISkillDriver.ButtonPressType.TapContinuous;

            AISkillDriver skill4 = gameObject.AddComponent<AISkillDriver>() as AISkillDriver;
            skill4.customName = "Special";
            skill4.skillSlot = RoR2.SkillSlot.Special;
            skill4.requireSkillReady = true;
            skill4.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            skill4.minDistance = 0;
            skill4.maxDistance = 50;
            skill4.selectionRequiresTargetLoS = true;
            skill4.activationRequiresTargetLoS = true;
            skill4.activationRequiresAimConfirmation = true;
            skill4.movementType = AISkillDriver.MovementType.StrafeMovetarget;
            skill4.aimType = AISkillDriver.AimType.AtMoveTarget;
            skill4.ignoreNodeGraph = false;
            skill4.resetCurrentEnemyOnNextDriverSelection = false;
            skill4.noRepeat = true;
            skill4.shouldSprint = false;
            skill4.buttonPressType = AISkillDriver.ButtonPressType.TapContinuous;

            AISkillDriver skill2 = gameObject.AddComponent<AISkillDriver>() as AISkillDriver;
            skill2.customName = "Secondary";
            skill2.skillSlot = RoR2.SkillSlot.Secondary;
            skill2.requireSkillReady = true;
            skill2.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            skill2.minDistance = 0;
            skill2.maxDistance = 20;
            skill2.selectionRequiresTargetLoS = true;
            skill2.activationRequiresTargetLoS = false;
            skill2.activationRequiresAimConfirmation = false;
            skill2.movementType = AISkillDriver.MovementType.ChaseMoveTarget;
            skill2.aimType = AISkillDriver.AimType.AtMoveTarget;
            skill2.ignoreNodeGraph = false;
            skill2.resetCurrentEnemyOnNextDriverSelection = false;
            skill2.noRepeat = false;
            skill2.shouldSprint = false;
            skill2.buttonPressType = AISkillDriver.ButtonPressType.TapContinuous;

            AISkillDriver skill1_alt = gameObject.AddComponent<AISkillDriver>() as AISkillDriver;
            skill1_alt.customName = "Shoot";
            skill1_alt.skillSlot = RoR2.SkillSlot.Primary;
            skill1_alt.requireSkillReady = true;
            skill1_alt.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            skill1_alt.minDistance = 0;
            skill1_alt.maxDistance = 20;
            skill1_alt.selectionRequiresTargetLoS = true;
            skill1_alt.activationRequiresTargetLoS = true;
            skill1_alt.activationRequiresAimConfirmation = true;
            skill1_alt.movementType = AISkillDriver.MovementType.StrafeMovetarget;
            skill1_alt.aimType = AISkillDriver.AimType.AtMoveTarget;
            skill1_alt.ignoreNodeGraph = false;
            skill1_alt.resetCurrentEnemyOnNextDriverSelection = false;
            skill1_alt.noRepeat = false;
            skill1_alt.shouldSprint = false;
            skill1_alt.buttonPressType = AISkillDriver.ButtonPressType.Hold;

            AISkillDriver skill1 = gameObject.AddComponent<AISkillDriver>() as AISkillDriver;
            skill1.customName = "Shoot";
            skill1.skillSlot = RoR2.SkillSlot.Primary;
            skill1.requireSkillReady = true;
            skill1.moveTargetType = AISkillDriver.TargetType.CurrentEnemy;
            skill1.minDistance = 0;
            skill1.maxDistance = 50;
            skill1.selectionRequiresTargetLoS = true;
            skill1.activationRequiresTargetLoS = true;
            skill1.activationRequiresAimConfirmation = true;
            skill1.movementType = AISkillDriver.MovementType.StrafeMovetarget;
            skill1.aimType = AISkillDriver.AimType.AtMoveTarget;
            skill1.ignoreNodeGraph = false;
            skill1.resetCurrentEnemyOnNextDriverSelection = false;
            skill1.noRepeat = false;
            skill1.shouldSprint = false;
            skill1.buttonPressType = AISkillDriver.ButtonPressType.TapContinuous;

            skill4.nextHighPriorityOverride = skill1;

            // Add default skills
            AddDefaultSkills(gameObject, ai, 10);
        }
    }
}
