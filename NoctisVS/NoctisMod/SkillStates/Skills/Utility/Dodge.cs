﻿using EntityStates;
using RoR2;
using UnityEngine;
using NoctisMod.Modules.Survivors;
using System;
using System.Collections.Generic;
using UnityEngine.Networking;
using NoctisMod.SkillStates.BaseStates;
using R2API;
using System.Reflection;
using R2API.Networking;
using NoctisMod.Modules;

namespace NoctisMod.SkillStates
{
    public class Dodge : BaseSkillState
    {
        private Animator animator;
        public NoctisController noctisCon;
        private Ray aimRay;
        private float rollSpeed;
        private float SpeedCoefficient;
        public static float initialSpeedCoefficient = Modules.StaticValues.dodgeSpeed;
        private float finalSpeedCoefficient = 0.1f;

        private float baseDuration = 0.6f;
        private float duration;
        private float dodgeEndTime = 0.8f;

        

        private Vector3 direction;


        public override void OnEnter()
        {

            base.OnEnter();
            noctisCon = gameObject.GetComponent<NoctisController>();
            this.animator = base.GetModelAnimator();
            aimRay = base.GetAimRay();
            noctisCon.weaponState = NoctisController.weaponType.NONE;

            direction = base.inputBank.moveVector;
            duration = baseDuration / attackSpeedStat;

            base.GetModelAnimator().SetFloat("Attack.playbackRate", attackSpeedStat);
            SpeedCoefficient = initialSpeedCoefficient * attackSpeedStat;

            characterBody.ApplyBuff(Modules.Buffs.armorBuff.buffIndex, 1);
            PlayAnimation();
        }

        private void PlayAnimation()
        {
            if (!characterMotor.isGrounded)
            {
                //base.PlayCrossfade("FullBody, Override", "AerialDodge", "Attack.playbackRate", this.duration, 0.05f);
                base.PlayAnimation("FullBody, Override", "AerialDodge", "Attack.playbackRate", this.duration * dodgeEndTime);
            }
            else
            if (characterMotor.isGrounded)
            {
                //base.PlayCrossfade("FullBody, Override", "Roll", "Attack.playbackRate", this.duration, 0.05f);
                base.PlayAnimation("FullBody, Override", "Roll", "Attack.playbackRate", this.duration * dodgeEndTime);
            }
        }

        private void RecalculateRollSpeed()
        {
            float num = this.moveSpeedStat;
            bool isSprinting = base.characterBody.isSprinting;
            if (isSprinting)
            {
                num /= base.characterBody.sprintingSpeedMultiplier;
            }
            this.rollSpeed = num * Mathf.Lerp(SpeedCoefficient, finalSpeedCoefficient, base.fixedAge / duration);
        }

        public override void OnExit()
        {
            base.OnExit();
            characterBody.ApplyBuff(Modules.Buffs.armorBuff.buffIndex, 0);
        }

        public override void Update()
        {
            base.Update();
            RecalculateRollSpeed();
            base.characterMotor.velocity = Vector3.zero;
                    

            if (base.fixedAge <= duration * dodgeEndTime)
            {
                //if (!characterMotor.isGrounded)
                //{
                //    base.SmallHop(base.characterMotor, StaticValues.dodgeHop);
                //}
                if (!characterMotor.isGrounded)
                {
                    base.StartAimMode(0.5f, true);
                    base.characterMotor.rootMotion += this.direction * this.rollSpeed * Time.fixedDeltaTime;
                    base.SmallHop(base.characterMotor, StaticValues.dodgeHop);
                }
                else
                if (characterMotor.isGrounded)
                {
                    base.characterDirection.forward = this.direction;
                    base.characterMotor.rootMotion += this.direction * this.rollSpeed * Time.fixedDeltaTime;
                }
            }
            
            if(base.fixedAge > duration)
            {
                this.outer.SetNextStateToMain();
                return;
            }

        }


        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }

    }
}


