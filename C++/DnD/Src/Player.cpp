#include "Player.h"

#include <stdexcept>

namespace DnD {

Player::Player(std::shared_ptr<IWeapon> weapon, std::shared_ptr<IArmour> armour)
    : m_armour(std::move(armour))
    , m_weapon(std::move(weapon))
{

}

void Player::setWeapon(std::shared_ptr<IWeapon> weapon)
{
    if (weapon == nullptr)
        throw std::runtime_error("Setting weapon with nullptr not allowed");

    m_weapon = std::move(weapon);
}
} // namespace DnD