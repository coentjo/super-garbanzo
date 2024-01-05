#pragma once

#include "Character.h"

namespace DnD {

class IArmour;
class IWeapon;

class Player :
    public Character
{
    Player(std::shared_ptr<IWeapon> weapon, std::shared_ptr<IArmour> armour);

    // Pre: weapon != nullptr
    void setWeapon(std::shared_ptr<IWeapon> weapon);

private:
    std::shared_ptr<IWeapon> m_weapon{};
    std::shared_ptr<IArmour> m_armour{};
};

} // namespace DnD