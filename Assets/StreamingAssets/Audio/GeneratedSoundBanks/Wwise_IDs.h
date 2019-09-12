/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID MX_GAME_END = 1542319017U;
        static const AkUniqueID MX_MAIN_MENU = 2694681644U;
        static const AkUniqueID MX_START_GAME = 3177518892U;
        static const AkUniqueID RESET_TIME_REMAINING = 1754383523U;
        static const AkUniqueID SFX_INCORRECT_MOVE = 386533466U;
        static const AkUniqueID SFX_MATCH = 1573519608U;
        static const AkUniqueID SFX_MOVE_TILE = 2104042053U;
        static const AkUniqueID SFX_SPECIAL_MATCH = 71291836U;
        static const AkUniqueID SFX_TILE_DROP = 2095104675U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace GAME_STATE
        {
            static const AkUniqueID GROUP = 766723505U;

            namespace STATE
            {
                static const AkUniqueID LEVEL = 2782712965U;
                static const AkUniqueID MENU = 2607556080U;
            } // namespace STATE
        } // namespace GAME_STATE

        namespace IN_LEVEL_STATE
        {
            static const AkUniqueID GROUP = 3408246077U;

            namespace STATE
            {
                static const AkUniqueID INGAME_STATE = 2678566748U;
            } // namespace STATE
        } // namespace IN_LEVEL_STATE

        namespace MAIN_MENU_STATE
        {
            static const AkUniqueID GROUP = 3862413590U;

            namespace STATE
            {
                static const AkUniqueID MAIN_MENU_STATE = 3862413590U;
            } // namespace STATE
        } // namespace MAIN_MENU_STATE

    } // namespace STATES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID PERCENTAGE_OF_TIME_LEFT = 2058349223U;
    } // namespace GAME_PARAMETERS

    namespace TRIGGERS
    {
        static const AkUniqueID LEVEL_SELECT_TRIGGER = 941363713U;
        static const AkUniqueID MATCH_4_TRIGGER = 524783928U;
        static const AkUniqueID STRIPED_COMBO_TRIGGER = 2672314184U;
    } // namespace TRIGGERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID GAME_SOUNDBANK = 3626155605U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID MASTER_SECONDARY_BUS = 805203703U;
    } // namespace BUSSES

}// namespace AK

#endif // __WWISE_IDS_H__
